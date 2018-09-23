using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinPlacer : MonoBehaviour {
    public GameObject coin;
    public GameObject floor;
    float theta = 0f;
    float xpos = 0f;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        theta = (GameObject.Find("longPlatform").transform.rotation.z * (Mathf.PI/180f) * 120);
        spawnCoinLeft();
        spawnCoinRight();
    }

    void spawnCoinLeft()
    {
        xpos = Random.Range(-7.5f, -4f);
        Vector3 whereToPlace = new Vector3((xpos * Mathf.Cos(theta)), (xpos * Mathf.Sin(theta))-.5f, (xpos * Mathf.Sin(theta)));
        var newCoin = Instantiate(coin, whereToPlace, GameObject.Find("longPlatform").transform.rotation);
        newCoin.transform.parent = floor.transform;
    }

    void spawnCoinRight()
    {
        xpos = Random.Range(4f, 7.5f);
        Vector3 whereToPlace = new Vector3((xpos * Mathf.Cos(theta)), (xpos * Mathf.Sin(theta)) - .5f, (xpos * Mathf.Sin(theta)));
        var newCoin = Instantiate(coin, whereToPlace, GameObject.Find("longPlatform").transform.rotation);
        newCoin.transform.parent = floor.transform;
    }
    void killItWithFire()
    {
        
    }

        

}
 