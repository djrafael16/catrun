using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontos : MonoBehaviour
{

  private void OnTriggerEnter2D(Collider2D col)
    {
    if(col.CompareTag("Player"))
        {
            placar.AdicionarPonto();
        }
    }


}
