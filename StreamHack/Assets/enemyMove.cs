using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    float moveSpeed = 2.5f;

    public coinSpawner spawner;
    public Transform spawnPos;

    public runCycle runCycle;

    public TMP_Text questionText;
    public GameObject questionpopup;

    public bool waitingForAnswer = false;

    string[] questions = { "Which one of these is a javascript framework?\nDjango, Rails, Node, Angular", "What is Git?\n\nautocomplete extension, CI/CD pipeline, version control system, None", "What is docker used for?\n\ndeploying apps, containerizing apps, running apps, None" };
    string[] answers = { "Angular", "version control system", "containerizing apps" };

    public string currentAns = "";

    public scoreManager scorem;

    // Start is called before the first frame update
    void Start()
    {
        spawner = FindObjectOfType<coinSpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 5)
        {
            if (!waitingForAnswer)
            {
                runCycle.isIdle = true;
                var coins = Object.FindObjectsOfType<coinMove>();
                var bgs = Object.FindObjectsOfType<bgMove>();
                for (int i = 0; i < coins.Length; i++)
                {
                    coins[i].moveSpeed = 0;
                    spawner.spawn = false;
                }
                for (int i = 0; i < bgs.Length; i++)
                {
                    bgs[i].moveSpeed = 0;
                }

                int rand = Random.Range(0, questions.Length);
                questionText.text = questions[rand];
                string answer = answers[rand];
                questionpopup.SetActive(true);
                waitingForAnswer = true;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        }
    }

    public void checkAnswer(string ans)
    {
        scorem.decrementEnergy();
        if (waitingForAnswer)
        {
            if (currentAns == ans)
            {
                resetPos();
                questionpopup.SetActive(false);
                waitingForAnswer = false;
            }
            else
            {
                Debug.Log("Wrong Answer");
                scorem.decrementEnergy();
            }
        }
    }

    public void resetPos()
    {
        transform.position = spawnPos.position;
        runCycle.isIdle = false;
        waitingForAnswer = false;
        var coins = Object.FindObjectsOfType<coinMove>();
        var bgs = Object.FindObjectsOfType<bgMove>();
        for (int i = 0; i < coins.Length; i++)
        {
            coins[i].moveSpeed = 2.5f;
            spawner.spawn = true;
        }
        for (int i = 0; i < bgs.Length; i++)
        {
            bgs[i].moveSpeed = 2.5f;
        }
    }
}
