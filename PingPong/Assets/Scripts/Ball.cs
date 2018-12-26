using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameObject paddle;
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
        	float calculation =  (this.transform.position.y - paddle.transform.position.y) / 2f;	
		rg2d.velocity = new Vector2(1f, calculation) * 7 + paddle.GetComponent<Rigidbody2D>().velocity;
	}
    }
}
