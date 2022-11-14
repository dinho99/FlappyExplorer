using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    // Logica del bottone restart
    public void ClickRestart() 
    {
        GameController.gameover = false;
        SceneManager.LoadScene(0); //metodo che carica la scena passata per parametro
    }
}
