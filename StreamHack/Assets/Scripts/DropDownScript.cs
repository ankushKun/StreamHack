using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DropDownScript : MonoBehaviour
{

    [SerializeField]
    TextMeshProUGUI mainText;

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
    3. <link=https://github.com/getify/You-Dont-Know-JS>You Don't Know JS </link >
    4. <link=https://github.com/lydiahallie/javascript-questions>JavaScript Questions</link>
    5. <link=https://github.com/ryanmcdermott/clean-code-javascript>Clean Code JavaScript</link>
    ";

    string web3 = @"
    1. <link=https://github.com/FrancescoXX/free-Web3-resources>Free Web3 Resources</link>
    2. <link=https://github.com/bekatom/awesome-ethereum>Awesome Ethereum</link>
    3. <link=https://github.com/yjjnls/awesome-blockchain>Awesome Blockchain </link >
    4. <link=https://github.com/OffcierCia/DeFi-Developer-Road-Map>DeFi Developer Road Map</link>
    5. <link=https://github.com/OpenZeppelin/awesome-openzeppelin>Awesome OpenZeplline</link>
    ";


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
