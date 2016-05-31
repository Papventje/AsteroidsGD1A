using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    public Text scoreText;
    public static int scoreInt = 0;

    public bool unlock1 = true;
    public bool unlock2 = false;
    public bool unlock3 = false;
    public bool unlock4 = false;
    public bool unlock5 = false;

    // Use this for initialization
    void Start () {
        unlock1 = true;
        unlock2 = false;
        unlock3 = false;
        unlock4 = false;
        unlock5 = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.P))
        {
            scoreInt += 50;
        }
        scoreText.text = "Score: " + scoreInt;
       
        if(scoreInt >= 50)
        {
            unlock1 = false;
            unlock2 = true;
        }
        if(scoreInt >= 100)
        {
            unlock2 = false;
            unlock3 = true;
        }
        if(scoreInt >= 150)
        {
            unlock3 = false;
            unlock4 = true;
        }
    }

    public static void IncreaseScore(int Amount)
    {
        scoreInt += Amount;
    }
}
