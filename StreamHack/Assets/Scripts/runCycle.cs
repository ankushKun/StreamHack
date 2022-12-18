using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class runCycle : MonoBehaviour
{
    public Sprite[] runSprites;
    SpriteRenderer spriteRenderer;

    public Sprite idle;

    public bool isIdle = false;
    private int i = 0;

    public int speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isIdle)
        {
            if (Time.frameCount % speed == 0)
            {
                spriteRenderer.sprite = runSprites[i];
                i++;
                if (i >= runSprites.Length)
                {
                    i = 0;
                }
            }
        }
        else
        {
            spriteRenderer.sprite = idle;
        }
    }

}
