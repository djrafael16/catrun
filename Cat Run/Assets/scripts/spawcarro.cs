using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawcarro : MonoBehaviour

{

    private float maxrangex;
    private float minrangex;

    public float rateSpaw;
    private float correnteSpaw;
    public int maxcarro;
    public GameObject prefabs;
    public List <GameObject> carro;

     public Transform spawmin;
    public Transform spawmax;

   

    


    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < maxcarro; i++)
        {
            GameObject tempcarro = Instantiate(prefabs) as GameObject;
            carro.Add(tempcarro);
            tempcarro.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        minrangex = spawmin.position.x;
        maxrangex = spawmax.position.x;
        
        correnteSpaw += Time.deltaTime;
        if(correnteSpaw > rateSpaw)
        {
            correnteSpaw = 0;
            spaw();
        }
    }


    private void spaw()
    {
        float rangeposition = Random.RandomRange(minrangex, maxrangex);
        GameObject tempcarro = null;
        
        for(int i=0; i < maxcarro; i++)
        {
          if(carro[i].activeSelf== false)
          {
              tempcarro = carro[i];
              break;
          }
        } 
        if(tempcarro != null)
        {
            tempcarro.transform.position = new Vector3 (rangeposition, transform.position.y, transform.position.z);
            tempcarro.SetActive(true);

        }
    }


}
