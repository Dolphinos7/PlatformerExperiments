using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private float speed;
	// Use this for initialization
	void Start () {
        speed = 8;
	}
	
	// Update is called once per frame
	void Update () {
        //get user input
        float axisX = Input.GetAxis("Horizontal");
        float axisY = Input.GetAxis("Vertical");

        //move the player left/right - vertical is not used
        transform.Translate(new Vector3(axisX, 0) * Time.deltaTime * speed);

        
	}   
}
