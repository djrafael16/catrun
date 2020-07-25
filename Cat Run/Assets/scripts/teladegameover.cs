using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teladegameover : MonoBehaviour
{
    
    public void Btn_Retonar()
    {
      SceneManager.LoadScene("CatRun");
      
    }
   public void Btn_Sair()
    {
 
       SceneManager.LoadScene("menulogin");
    }

}




