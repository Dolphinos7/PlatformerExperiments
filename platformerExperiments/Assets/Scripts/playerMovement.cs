using UnityEngine;
public class playerMovement : MonoBehaviour {
    // Use this for initialization
    bool keyHeld = false;
	void Start () {
        
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey("d"))
        {
            FindObjectOfType<Rigidbody2D>().velocity = transform.right * 120 * Time.deltaTime;
        }
        else if (Input.GetKey("a"))
        {
            FindObjectOfType<Rigidbody2D>().velocity = transform.right * -120 * Time.deltaTime;
        }
        else
            FindObjectOfType<Rigidbody2D>().velocity = transform.up * 0;
    }
}
