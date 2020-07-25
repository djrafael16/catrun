using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverfundo : MonoBehaviour
{
    public float Tamanhobox;
    public int Quantidade;


   private void OnTriggerEnter2D (Collider2D col)
   {
       if (col.CompareTag("Fundo"))
       {
           Vector3 pos = col.transform.position; 
           pos.x += Tamanhobox * Quantidade;
           col.transform.position = pos;
        }
   }
}
