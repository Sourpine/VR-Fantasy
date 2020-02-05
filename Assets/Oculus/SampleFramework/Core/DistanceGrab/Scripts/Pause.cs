using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Pause : MonoBehaviour
{
   
    void Start()
    {
        
    }

  
    void Update()
    {
        OVRInput.GetDown(OVRInput.Button.Start);
        {
            if (Time.timeScale == 1)
            {
                GetComponent<Canvas>().enabled = true;
                Time.timeScale = 0;

            }
            else if (Time.timeScale == 0 )
            {
                Resume();
            }
        }
    }
    public void Resume()
    {
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();

    }
}
