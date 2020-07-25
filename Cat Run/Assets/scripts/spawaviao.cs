using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawaviao : MonoBehaviour
{
    private float maxrangex;
    private float minrangex;

    public float minrangey;
    public float maxrangey;

    public float rateSpaw;
    private float correnteSpaw;
    public int maxaviao;
    public GameObject prefabs;
    public List <GameObject> aviao;

     public Transform spawmin;
    public Transform spawmax;

   

    


    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < maxaviao; i++)
        {
            GameObject tempaviao = Instantiate(prefabs) as GameObject;
            aviao.Add(tempaviao);
            tempaviao.SetActive(false);
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
        float rangepositionx = Random.RandomRange(minrangex, maxrangex);
        float rangepositiony = Random.RandomRange(minrangey, maxrangey);
        GameObject tempaviao = null;
        
        for(int i=0; i < maxaviao; i++)
        {
          if(aviao[i].activeSelf== false)
          {
              tempaviao = aviao[i];
              break;
          }
        } 
        if(tempaviao != null)
        {
            tempaviao.transform.position = new Vector3 (rangepositionx, rangepositiony, transform.position.z);
            tempaviao.SetActive(true);

        }
    }

}
