using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject gameover;
    public GameObject restart;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameController.gameover && Punti.punteggio < 5) //se clicca il tasto sx e non è finito il gioco
        {
            rb.velocity = new Vector2(0f, 7f); //salto
        } 
        if (Input.GetMouseButtonDown(0) && !GameController.gameover && Punti.punteggio >= 5)
        {
            rb.velocity = new Vector2(0f, -7f); //salto con gravità invertita
        }
    }

    // Logica dietro la collisione
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.gameover = true;
        gameover.SetActive(true);
        restart.SetActive(true);
    }
}
