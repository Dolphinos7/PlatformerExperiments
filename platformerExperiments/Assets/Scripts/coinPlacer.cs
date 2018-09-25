using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinPlacer : MonoBehaviour {
    public GameObject coin;
    public GameObject floor;
    bool spawnSide = true;
    float theta = 0f;
    float xpos = 0f;
    GameObject newCoinL;
    GameObject newCoinR;

    // Use this for initialization
    void Start()
    {
        spawnCoinLeft();
    }

    // Update is called once per frame
    void FixedUpdate() {
        theta = (GameObject.Find("longPlatform").transform.rotation.z * (Mathf.PI / 180f) * 120f);

    }
    public void spawnCoinR()
    {
        Destroy(newCoinR);
        spawnCoinLeft();
    }
    public void spawnCoinL()
        { 
            Destroy(newCoinL);
            spawnCoinRight();
        }


    void spawnCoinLeft()
    {
        xpos = Random.Range(-7.5f, -4f);
        Vector3 whereToPlace = new Vector3((xpos * Mathf.Cos(theta)), (xpos * Mathf.Sin(theta))-.5f, (xpos * Mathf.Sin(theta)));
        newCoinL = Instantiate(coin, whereToPlace, GameObject.Find("longPlatform").transform.rotation);
        newCoinL.transform.parent = floor.transform;
        newCoinL.name = "leftCoin";
    }

    void spawnCoinRight()
    {
        xpos = Random.Range(4f, 7.5f);
        Vector3 whereToPlace = new Vector3((xpos * Mathf.Cos(theta)), (xpos * Mathf.Sin(theta)) - .5f, (xpos * Mathf.Sin(theta)));
        newCoinR = Instantiate(coin, whereToPlace, GameObject.Find("longPlatform").transform.rotation);
        newCoinR.transform.parent = floor.transform;
        newCoinR.name = "rightCoin";
    }
    void killItWithFire()
    {
        
    }
}
 