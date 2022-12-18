using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChatHandler : MonoBehaviour
{
    public string currentMessage = "";
    public ChatManager chat;

    public TMP_InputField inputField;

    public enemyMove enemy;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            setCurrentMessage(inputField.text);
            if (currentMessage != "")
            {
                sendCurrentMessage();
                if (enemy.waitingForAnswer)
                {
                    enemy.checkAnswer(currentMessage);
                }
                setCurrentMessage("");
                inputField.text = "";

            }
        }

    }

    public async void sendCurrentMessage()
    {
        await chat.SendMessageAsync(currentMessage);
        currentMessage = "";
    }

    public void setCurrentMessage(string m)
    {
        currentMessage = m;
    }
}
