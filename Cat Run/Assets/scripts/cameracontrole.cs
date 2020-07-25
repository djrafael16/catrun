using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrole : MonoBehaviour
{
   public Transform Player;
    float distancia;
    void Start()
    {
        distancia = transform.position.x - Player.position.x; // distancia da camera com relação a posição do player 
    }
        
     void Update()
            {
                if(Player != null) // persongem diferente de nulo entra no if

                {
                    Vector3 posicao = transform.position;
                    posicao.x = Player.position.x + distancia; // utiliza a posição do player mais a distancia 
                    transform.position = posicao; // define a posição da camera com relação ao player 
                 }
            }

}
