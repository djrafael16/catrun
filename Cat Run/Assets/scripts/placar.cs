using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class placar : MonoBehaviour
{

    static int placar_player = 0;
    static int maior_placar;

   private void Start()
    {
        placar_player = 0;
        maior_placar = PlayerPrefs.GetInt("MaiorPlacar", 0);

    }
 private void Update()
    {
        GetComponent<Text>().text = "Placar:" + placar_player.ToString();
    }
static public void AdicionarPonto()
    {
        placar_player++;
        if(placar_player > maior_placar)
        {
            maior_placar = placar_player;
        }

    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("MaiorPlacar", maior_placar);
    }
}

