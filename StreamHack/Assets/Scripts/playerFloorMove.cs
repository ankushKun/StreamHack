using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerFloorMove : MonoBehaviour
{
    public Transform upPos;
    public Transform restPos;
    public Transform downPos;

    public float speed = 2f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            // Debug.Log("down");
            transform.position = Vector3.MoveTowards(transform.position, downPos.transform.position, step);
        }
        // else
        // {
        //     Debug.Log("rest");
        //     transform.position = Vector3.MoveTowards(transform.position, restPos.transform.position, step);
        // }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // Debug.Log("up");
            transform.position = Vector3.MoveTowards(transform.position, upPos.transform.position, step);
        }
        // else
        // {
        //     Debug.Log("rest");
        //     transform.position = Vector3.MoveTowards(transform.position, restPos.transform.position, step);
        // }

        // exit

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }


    }
}
