using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private void Awake() {
        rb = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    // Update is called once per frame
    void FixedUpdate()
    {
        
        
        // transform.Translate(new Vector2(1f,0f)* moveSpeed *Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D colli)
    {
        if(colli.gameObject.tag == "Player"){
            rb.MovePosition(rb.position + new Vector2(1f,1f)*Time.deltaTime);
        }
        
        
    }
}
