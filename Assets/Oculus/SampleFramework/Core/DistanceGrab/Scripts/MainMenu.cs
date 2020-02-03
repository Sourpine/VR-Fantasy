using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void ButtonNewGame()
    {
        SceneManager.LoadScene("City");
 
    }


    public void Buttonquit()
    {
        Application.Quit();
    }

   
}
