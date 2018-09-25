using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private float speed;
    bool canHitLeft = true;
    bool canHitRight = false;

    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.name == "leftCoin"&& canHitLeft == true)
        {
            Debug.Log("hitleftcoin");
            canHitLeft = false;
            FindObjectOfType<coinPlacer>().spawnCoinL();
            canHitRight = true;
        }
        if(collision.gameObject.name == "rightCoin"&&canHitRight == true)
        {
            Debug.Log("hitrightcoin");
            canHitRight = false;
            FindObjectOfType<coinPlacer>().spawnCoinR();
            canHitLeft = true;
            
        }
    }

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
