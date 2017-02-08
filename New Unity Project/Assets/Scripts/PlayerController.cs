using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float velocity_x;
	public float velocity_y;
	public float jump_height;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey (KeyCode.D)) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (velocity_x, GetComponent<Rigidbody2D>().velocity.y);
		}
		else if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.A)) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-velocity_x, GetComponent<Rigidbody2D>().velocity.y);
		}
		if (Input.GetKeyDown (KeyCode.Space) || Input.GetKey (KeyCode.W)) 
		{
			GetComponent<Rigidbody2D>().velocity = new Vector2 (GetComponent<Rigidbody2D>().velocity.x, jump_height);
		}
	}
}
