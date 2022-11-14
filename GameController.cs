using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float spawnTimer;
    float spawnRate = 3f;
    public GameObject block;
    public static bool gameover; //statica e pubblica così che tutti i gameObject la possono modificare

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameover)
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer >= spawnRate) //se trascorrono 3 secondi
            {
                spawnTimer -= spawnRate; //torna a circa 0
                Vector2 spawnPos = new Vector2(2f, Random.Range(-3f, 3f)); //la y varia ogni spawn casualmente
                Instantiate(block, spawnPos, Quaternion.identity); //oggetto che spawna, posizione di spawn, rotazione (nessuna)
            }
        }
    }
}
