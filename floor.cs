using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor : MonoBehaviour
{
    Vector2 posIniziale;
    // Start is called before the first frame update
    void Start()
    {
        posIniziale = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        /*Fino a che non finisce il pavimento, scorri a sinistra, altrimenti rinizia*/
        if (transform.position.x >= 0.05)
            transform.position = new Vector2(transform.position.x - 0.01f, //così a ogni frame torna a sx 
                 transform.position.y);
        else
            transform.position = posIniziale;
    }
}
