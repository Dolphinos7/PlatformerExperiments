using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update () {
        if (getPlayerPositionY() < -10)
        {
            gameOver();
        }
        Debug.Log(getPlayerPositionY());
	}
    /**
     * Returns the current value of the player-character's Y position
     */
    public float getPlayerPositionY()
    {
        return GameObject.Find("testSprite").transform.position.y;
    }
    /**
     * Procedure for what happens when the game is over
     */
     public void gameOver()
    {
        Debug.Log("Game Over!");
        SceneManager.LoadScene("levelTesting");
    }
}

    