using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class efeitofundo : MonoBehaviour
{
    public Rigidbody2D player;

    private void FixedUpdate ()
 
    {

        float vel = player.velocity.x * 0.20f;
        transform.position = transform.position + Vector3.right * vel * Time.deltaTime;

    }
  
}
