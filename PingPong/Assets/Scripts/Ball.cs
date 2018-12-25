using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	private Rigidbody2D rg2d;
    // Start is called before the first frame update
    void Start()
    {
    	rg2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           	Vector2 vel = new Vector2(5f, 0f);
        	rg2d.velocity = vel;


        }
    }
}
