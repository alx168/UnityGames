using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
	[SerializeField]
	float speed;

	private Vector2 direction;
	private float radius;
	private bool canMove = false;

	[SerializeField]
	Scores what;

	[SerializeField]
	PlayerMovement play1;

	[SerializeField]
	PlayerMovement play2;
    // Start is called before the first frame update
    void Start()
    {
        direction = Vector2.one.normalized;
        radius = transform.localScale.x /2;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(direction * speed * Time.deltaTime);
    	if( canMove == true)
    	{
    		transform.Translate(direction * speed * Time.deltaTime);
        	if(transform.position.y < PlayerMovement.bottomLeft.y + radius && direction.y < 0){
        		direction.y = -direction.y;
        	}
        	if(transform.position.y > PlayerMovement.topRight.y - radius && direction.y > 0){
        		direction.y = -direction.y; 
        	}
        	if(transform.position.x < PlayerMovement.bottomLeft.x + radius && direction.x < 0){
        		direction.x = -direction.x;
        	}
        	if(transform.position.x > PlayerMovement.topRight.x - radius && direction.x > 0){
        		direction.x = -direction.x; 
        	}

        }
    }

    void OnTriggerEnter2D(Collider2D other){
    	canMove = true;
    	if( other.tag == "Paddle"){
    		int playerNumber = other.GetComponent<PlayerMovement>().playerNumber;

    		//transform.Translate(direction * speed * Time.deltaTime);
    		if(playerNumber == 1 && direction.x > 0)
    			direction.x = -direction.x;

    		if(playerNumber == 0 && direction.x < 0)
    			direction.x = -direction.x;

    	}
    	if( other.tag == "Goal"){
    		Debug.Log("hit goal");
    		transform.position = new Vector3( 0f, 0f, 0f);
    		what.UpdateScore(1, 0);
    		play1.transform.position = new Vector3( -9f, 0f, 0f );
    		play2.transform.position = new Vector3( 9f, 0f, 0f );

    		canMove = false;
    	}
    	
    	if( other.tag == "Goal2"){
    		Debug.Log("hit goal");
    		transform.position = new Vector3( 0f, 0f, 0f);
    		what.UpdateScore(0, 1);

    		play1.transform.position = new Vector3( -9f, 0f, 0f );
    		play2.transform.position = new Vector3( 9f, 0f, 0f );
    		canMove = false;
    	}
    }
}
