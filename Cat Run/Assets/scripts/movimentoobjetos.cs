using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentoobjetos : MonoBehaviour
{
    public float velocidade;
    public GameObject veiculo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3 (velocidade, 0, 0) * Time.deltaTime;

    }

     private void OnTriggerEnter2D (Collider2D col)
   {
       if (col.CompareTag("Camera"))
       {
           veiculo.SetActive(false);
       }
    }
}


