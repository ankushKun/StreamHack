using System;
using System.Linq;
using System.Threading.Tasks;
using StreamChat.Core;
using StreamChat.Core.Helpers;
using StreamChat.Core.Models;
using StreamChat.Core.StatefulModels;
using StreamChat.Libs.Auth;
using UnityEngine;

public class ChatManager : MonoBehaviour
{
    private IStreamChatClient client;
    private IStreamChannel _mainChannel;

    private void OnMessageReceived(IStreamChannel channel, IStreamMessage message)
    {
        Debug.Log($"Message \"{message.Text}\" was sent by {message.User.Name} to {channel.Id} channel");
    }

    // private void OnMessageDeleted(IStreamChannel channel, IStreamMessage message, bool isHardDelete)
    // {
    //     Debug.Log($"Message with ID {message.Id} was deleted from {channel.Id} channel.");
    // }

    // private void OnReactionAdded(IStreamChannel channel, IStreamMessage message, StreamReaction reaction)
    // {
    //     Debug.Log($"Reaction {reaction.Type} was added by {reaction.User.Id}");
    // }

    private void Start()
    {
        // Create chat client
        client = StreamChatClient.CreateDefaultClient();
        StartChatAsync().LogExceptionsOnFailed();
    }

    private void Update()
    {
        if (!client.IsConnected || _mainChannel == null)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            var messageText = "Hello, world! Current local time is: " + DateTime.Now;
            SendMessageAsync(messageText).LogExceptionsOnFailed();
        }
    }

    private async Task StartChatAsync()
    {
        var localUserData = await client.ConnectUserAsync("kuyx5zthbusf", "kuyx5zthbusf", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VyX2lkIjoia3V5eDV6dGhidXNmIn0.MF4y1mgpeYi0RSmS4_OffYVY1NLCXzExqzDH7PS_6Hk");
        Debug.Log($"User {localUserData.User.Id}, {localUserData.UserId} is now connected!");

        // Create a channel with "main" ID
        _mainChannel = await client.GetOrCreateChannelWithIdAsync(ChannelType.Messaging, "main");
        Debug.Log($"channel with ID: {_mainChannel.Id} created");

        // Subscribe to channel events so we can react to new messages, reactions, etc.
        _mainChannel.MessageReceived += OnMessageReceived;
        // _mainChannel.MessageDeleted += OnMessageDeleted;
        // _mainChannel.ReactionAdded += OnReactionAdded;

        foreach (var message in _mainChannel.Messages)
        {
            Debug.Log($"Channel message: {message.Text}, sent by: {message.User.Id} on {message.CreatedAt}");
        }

    }

    private async Task SendMessageAsync(string text)
    {
        var message = await _mainChannel.SendNewMessageAsync(text);
        Debug.Log($"Message sent: {message.Text}");
    }

    private void OnDestroy()
    {
        if (_mainChannel != null)
        {
            _mainChannel.MessageReceived += OnMessageReceived;
            // _mainChannel.MessageDeleted += OnMessageDeleted;
            // _mainChannel.ReactionAdded += OnReactionAdded;
        }
        DisconnectAsync();
    }

    public async Task DisconnectAsync()
    {
        await client.DisconnectUserAsync();
        Debug.Log($"User disconnected");
    }


}