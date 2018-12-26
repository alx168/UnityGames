using UnityEngine;
using System;

 
public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
   	public GameObject spriteRenderer;
   	public float restrictBack;
   	public int playerNum;
	public string[] moves = new string[4];
   	private float restrictFront;
 	private float restrictBottom;
 	private float restrictTop;


    private void Start() {
    	SpriteRenderer board = gameObject.GetComponent<SpriteRenderer>();
        if(board != null) {
            restrictFront = 0f; // any vector2
            restrictBottom = -4f;
            restrictTop = 4f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moves[0]) && restrictTop > this.transform.position.y) // w
        {
        	Vector3 temp = new Vector3(0,.15f,0);  
        	this.transform.position += temp;

        }
        if (Input.GetKey(moves[2]) && restrictBottom < this.transform.position.y)  // s
       	{
             Vector3 temp = new Vector3(0,-.15f,0);  
        	this.transform.position += temp;
        }
	if(playerNum == 0){
          if (Input.GetKey(moves[1]) && this.transform.position.x > restrictBack) // a
          {
            Vector3 temp = new Vector3(-.15f,0,0);  
            this.transform.position += temp;
          }
          if (Input.GetKey(moves[3]) && this.transform.position.x < restrictFront) // d
          {
            Vector3 temp = new Vector3(.15f,0,0);  
        	this.transform.position += temp;
          }
	}else{
          if (Input.GetKey(moves[1]) && this.transform.position.x > restrictFront) // a
          {
            Vector3 temp = new Vector3(-.15f,0,0);  
            this.transform.position += temp;
          }
          if (Input.GetKey(moves[3]) && this.transform.position.x < restrictBack) // d
          {
            Vector3 temp = new Vector3(.15f,0,0);  
        	this.transform.position += temp;
          }
	
	}
    }
}
