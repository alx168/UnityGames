﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public Rigidbody2D theRB;
	public float moveSpeed;
	public bool canMove = true;

	public Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if( canMove){
        	theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")) * moveSpeed;
        }

        myAnim.SetFloat("MoveX", theRB.velocity.x);
        myAnim.SetFloat("MoveY", theRB.velocity.y);

        if(Input.GetAxisRaw("Horizontal")  == 1  ||  Input.GetAxisRaw("Horizontal")  == -1  || Input.GetAxisRaw("Vertical")  == 1  ||  Input.GetAxisRaw("Vertical")  == -1){
        	myAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
        	myAnim.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
        	
        
    }
}
