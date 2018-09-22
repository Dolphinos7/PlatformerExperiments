using UnityEngine;
public class playerMovement : MonoBehaviour {
    // Use this for initialization
    bool keyHeld = false;
    bool onGround = false;
    float maxSpeed = 6f;
    void OnCollisionEnter2D(UnityEngine.Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.tag == "Ground")
        {
            onGround = true;
        }
    }




    void Start ()
    {

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (gameObject.GetComponent<Rigidbody2D>().velocity.magnitude > maxSpeed)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = gameObject.GetComponent<Rigidbody2D>().velocity.normalized * maxSpeed;
        }
        Vector2 currentVelocity = gameObject.GetComponent<Rigidbody2D>().velocity;
        Debug.Log(currentVelocity);
        keyHeld = false;
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * -500 * Time.deltaTime);
        if (Input.GetKey("space")&&onGround==true)
        {
            onGround = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 10000 * Time.deltaTime);
            
        }
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
        if(keyHeld==false&&onGround==true)
            FindObjectOfType<Rigidbody2D>().velocity = transform.up * 0 * Time.deltaTime;
    }
}
