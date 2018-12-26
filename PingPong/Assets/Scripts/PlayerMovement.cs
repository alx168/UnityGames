using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public static Vector2 bottomLeft;
    public static Vector2 topRight;
    public static Vector2 center;
    public string[] moves;
    public int playerNumber;

    void Start()
    {
        bottomLeft = Camera.main.ScreenToWorldPoint (new Vector2 (0,0));
        topRight   = Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width, Screen.height));
        center     = Camera.main.ScreenToWorldPoint (new Vector2 (Screen.width/2, Screen.height/2));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moves[0]) ) // w
        {
            if( transform.position.y > topRight.y - 1.25 ){

            }else{
            	Vector3 temp = new Vector3(0,.15f,0);
            	transform.Translate(temp);
            }

        }
        if (Input.GetKey(moves[2]) ) // s
        {
            if( transform.position.y < bottomLeft.y + 1.25 ){

            }else{
            	Vector3 temp = new Vector3(0,-.15f,0);
            	transform.Translate(temp);
            }

        }

        if(playerNumber == 0){
        	if(Input.GetKey(moves[3])){ //d

        		if( transform.position.x > center.x/2 - .25){ 

            	}else{
            		Vector3 temp = new Vector3(.15f,0f,0);
            		transform.Translate(temp);
            	}
        	}

        	if(Input.GetKey(moves[1])){ // a 
        		if( transform.position.x < bottomLeft.x + .25){

            	}else{
            		Vector3 temp = new Vector3(-.15f,0f,0);
            		transform.Translate(temp);
            	}
        	}

        }else{
        	if(Input.GetKey(moves[1])){ //left
        		if( transform.position.x < center.x + .25){ 

            	}else{
            		Vector3 temp = new Vector3(-.15f,0f,0);
            		transform.Translate(temp);
            	}
        	}

        	if(Input.GetKey(moves[3])){ // right
        		if( transform.position.x > topRight.x - .3){

            	}else{
            		Vector3 temp = new Vector3(.15f,0f,0);
            		transform.Translate(temp);
            	}
        	}
        }

    }
}
