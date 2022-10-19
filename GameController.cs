using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float spawnTimer;
    floar spawnRate = 3f;
    public GameObject asteroide;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnRate) //se sono trascorsi tre secondi
        {
            spawnTimer -= spawnRate;
            Vector2 spawnPos = new Vector2(2f, Random.Range(-1f, 2f)); //così che gli ostacoli spawnano in altezze differenti
            Instantiate(asteroide, spawnPos, Quaternion.identity); //3 parametro = non ruota
        }
    }
}
