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

    string react = @"
    1. <link=https://github.com/taniarascia/takenote>Take Note</link>
    2. <link=https://github.com/sanyuan0704/react-cloud-music>React Cloud Music</link>
    3. <link=https://github.com/karlhadwen/todoist>ToDoist </ link >
    4. <link=https://github.com/paulhoughton/mortgage>Mortgage Calculator</link>
    5. <link=https://github.com/dabit3/write-with-me>Write With Me Blog</link>
    ";

    string python = @"
    1. <link=https://github.com/wesbos/JavaScript30>JavaScript 30</link>
    2. <link=https://github.com/denysdovhan/wtfjs>WTF JS</link>
    3. <link=https://github.com/getify/You-Dont-Know-JS>You Don't Know JS </ link >
    4. <link=https://github.com/lydiahallie/javascript-questions>JavaScript Questions</link>
    5. <link=https://github.com/ryanmcdermott/clean-code-javascript>Clean Code JavaScript</link>
    ";

    string web3 = @"
    1. <link=https://github.com/FrancescoXX/free-Web3-resources>Free Web3 Resources</link>
    2. <link=https://github.com/bekatom/awesome-ethereum>Awesome Ethereum</link>
    3. <link=https://github.com/yjjnls/awesome-blockchain>Awesome Blockchain </ link >
    4. <link=https://github.com/OffcierCia/DeFi-Developer-Road-Map>DeFi Developer Road Map</link>
    5. <link=https://github.com/OpenZeppelin/awesome-openzeppelin>Awesome OpenZeplline</link>
    ";

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

    public void onValueChange(int val)
    {
        if (val == 0)
        {
            mainText.text = react;
        }
        else if (val == 1)
        {
            mainText.text = python;

        }
        else if (val == 2)
        {
            mainText.text = web3;

        }
    }
}
