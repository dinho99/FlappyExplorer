using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    bool contato = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.gameover) {
            transform.position = new Vector2(transform.position.x - 0.01f, //così a ogni frame torna a sx 
                transform.position.y);
        }
        
        if (transform.position.x <= -6) //se l'ostacolo esce a sinistra dallo schermo
            Destroy(gameObject); //distruggilo

        if(!contato && transform.position.x < -4)
        {
            contato = true;
            Punti.punteggio += 1;
        }
    }
}
