using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{

    
    public void Btn_jogar()
    {
      SceneManager.LoadScene("CatRun");
      
    }
    public void Btn_Sair()
    {
 
        Application.Quit();
        if(Input.GetKeyDown(KeyCode.Q))
        {
            Application.Quit();
        }

    }

}
