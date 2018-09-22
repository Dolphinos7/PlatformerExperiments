using UnityEngine;
public class playerMovement : MonoBehaviour {
    // Use this for initialization
    bool keyHeld = false;
    bool onGround = false;
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
        keyHeld = false;
        if (Input.GetKey("space")&&onGround==true)
        {
            onGround = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 10000 * Time.deltaTime);
            
        }
        if (Input.GetKey("d"))
        {
            keyHeld = true;
            FindObjectOfType<Rigidbody2D>().velocity = transform.right * 120 * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            keyHeld = true;
            FindObjectOfType<Rigidbody2D>().velocity = transform.right * -120 * Time.deltaTime;
        }
        if(keyHeld==false&&onGround==true)
            FindObjectOfType<Rigidbody2D>().velocity = transform.up * 0 * Time.deltaTime;
    }
}
