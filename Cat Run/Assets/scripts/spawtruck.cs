using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawtruck : MonoBehaviour
{
    private float maxrangex;
    private float minrangex;

    public float rateSpaw;
    private float correnteSpaw;
    public int maxtruck;
    public GameObject prefabs;
    public List <GameObject> truck;

    public Transform spawmin;
    public Transform spawmax;

    


    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < maxtruck; i++)
        {
            GameObject temptruck = Instantiate(prefabs) as GameObject;
            truck.Add(temptruck);
            temptruck.SetActive(false);
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
        GameObject temptruck= null;
        
        for(int i=0; i < maxtruck; i++)
        {
          if(truck[i].activeSelf== false)
          {
              temptruck = truck[i];
              break;
          }
        } 
        if(temptruck != null)
        {
            temptruck.transform.position = new Vector3 (rangeposition, transform.position.y, transform.position.z);
            temptruck.SetActive(true);

        }
    }
}
