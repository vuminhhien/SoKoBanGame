using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D colli)
    {
        if(colli.gameObject.tag == "Player"){
            transform.position = Vector2.MoveTowards(transform.position,new Vector2(10f,transform.position.y),
            3f*Time.deltaTime);
            Time.timeScale = 0;
        }
        else 
        if(colli.gameObject.tag == "lava"){
            Destroy(GameObject.Find("rock"));
        }
    }
}
