using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinMove : MonoBehaviour
{
    public float moveSpeed = 2.5f;
    public bool dontDelete = false;

    public BoxCollider2D player;

    public scoreManager scoreMan;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dontDelete) { return; }
        transform.position = new Vector3(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        if (transform.position.x <= -28)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Do something
        // Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            scoreMan.incrementScore();
            Destroy(gameObject);
        }

    }
}
