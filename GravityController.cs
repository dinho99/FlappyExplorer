using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Punti.punteggio == 5)
            Physics2D.gravity = new Vector2(0, 9.8f);
    }
}
