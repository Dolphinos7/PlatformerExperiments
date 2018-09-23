using UnityEngine;
public class playerMovement : MonoBehaviour {
    //Initializing Variables
    bool keyHeld = false;
    bool onGround = false;
    float maxSpeed = 6f; //Speed limit for player

    //Tells the player he is on the ground when he makes contact with it
    void OnCollisionEnter2D(UnityEngine.Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }

	void FixedUpdate () {
        //Used to know when key is held
        keyHeld = false;

        //Limits speed of player
        if (gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > maxSpeed)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity.normalized * maxSpeed;
        }

        //Jumps
        if (Input.GetKey("space")&&onGround==true)
        {
            onGround = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 250 * Time.deltaTime, ForceMode2D.Impulse);
            
        }

        //Horizontal Movement
        if (Input.GetKey("d"))
        {
            keyHeld = true;
            FindObjectOfType<Rigidbody2D>().AddForce(transform.right * 1000 * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            keyHeld = true;
            FindObjectOfType<Rigidbody2D>().AddForce(transform.right * -1000 * Time.deltaTime);
        }

        //Stops movement when no key is pressed and on ground
        if(keyHeld==false && onGround == true)
            FindObjectOfType<Rigidbody2D>().velocity = transform.up * 0 * Time.deltaTime;
    }
}
