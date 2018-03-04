using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody2D playerRB2D;

	
	void Start () {
       playerRB2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");


        playerRB2D.velocity= new Vector2(moveHorizontal, moveVertical); ;
        
    }


}
