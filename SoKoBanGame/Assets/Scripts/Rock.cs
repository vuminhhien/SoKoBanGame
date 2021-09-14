using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D colli)
    {
        if(colli.gameObject.tag == "Player"){
            transform.position= Vector2.MoveTowards(transform.position,
            new Vector2( 10f,transform.position.y),1f*Time.deltaTime);
        }
        
        
    }
}
