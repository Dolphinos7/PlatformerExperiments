
using UnityEngine;

public class Movement : MonoBehaviour {

    public Rigidbody2D bod;
    public float speed = 10.0f;

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World!");
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.UpArrow)){

            bod.AddForce( new Vector2( 0.0f, speed ) );

        }

        if (Input.GetKey(KeyCode.DownArrow)){

            bod.AddForce( new Vector2( 0.0f, -speed ) );

        }

        if (Input.GetKey(KeyCode.LeftArrow)){

            bod.AddForce( new Vector2( -speed, 0.0f ) );

        }

        if (Input.GetKey(KeyCode.RightArrow)){
           
            bod.AddForce( new Vector2( speed, 0.0f ) );

        }

        if (Input.GetKeyUp(KeyCode.UpArrow)){

            bod.velocity = new Vector2( bod.velocity.x , 0.0f );

        }

        if (Input.GetKeyUp(KeyCode.DownArrow)){
            
            bod.velocity = new Vector2( bod.velocity.x , 0.0f );

        }

        if (Input.GetKeyUp(KeyCode.LeftArrow)){
            
            bod.velocity = new Vector2( 0.0f , bod.velocity.y );

        }

        if (Input.GetKeyUp(KeyCode.RightArrow)){
            
            bod.velocity = new Vector2( 0.0f , bod.velocity.y );

        }

    }
}
