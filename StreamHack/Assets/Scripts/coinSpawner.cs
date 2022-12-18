using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class coinSpawner : MonoBehaviour
{
    public GameObject spawnExample;

    public bool spawn = true;

    public GameObject enemy;
    public Transform enemySpawn;

    public Transform[] spawnPositions = new Transform[3];
    public Sprite[] spawnableSprites;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {
            if (Time.frameCount % 100 == 0)
            {
                int spriteIdx = Random.Range(0, spawnableSprites.Length);
                int spawnPosIdx = Random.Range(0, spawnPositions.Length);

                GameObject coin = Instantiate(spawnExample);
                Sprite toSpawn = spawnableSprites[spriteIdx];
                coin.GetComponent<SpriteRenderer>().sprite = toSpawn;
                coin.GetComponent<coinMove>().dontDelete = false;
                Transform pos = spawnPositions[spawnPosIdx];
                coin.transform.position = pos.position;
            }

            if (Time.frameCount % 2000 == 0)
            {
                enemy.SetActive(true);
                enemy.transform.position = enemySpawn.position;
            }
        }

    }
}
