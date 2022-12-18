using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;


public class TextLink : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    public Camera cam;


    [SerializeField]
    TextMeshProUGUI mainText;

    string myText;


    void Start()
    {
        populateText();
    }

    void populateText()
    {
        myText = "Hello World <link=https://prathamesh.co>Link</link>\n";
        myText = myText + "from <b>Unity</b>";

        // Debug.Log(myText);

        // mainText.text = myText;
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        if (eventData.button == PointerEventData.InputButton.Left)
        {


            Camera mainCamera = Camera.main;

            // Debug.Log(mainCamera);

            Debug.Log(mainText.textInfo.linkInfo[0].GetLinkID());


            // Fix the null value - Camera (current, main)
            int index = TMP_TextUtilities.FindIntersectingLink(mainText, Input.mousePosition, null);

            Debug.Log(index);

            if (index > -1)
            {
                OpenURL(mainText.textInfo.linkInfo[index].GetLinkID());
            }
        }
    }

    public void OpenURL(string url)
    {
        Application.OpenURL(url);
    }


}
