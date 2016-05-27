using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    public Text scoreText;
    public static int scoreInt = 0;

    public bool unlock1 = true;
    public bool unlock2 = false;



    // Use this for initialization
    void Start () {
        unlock1 = true;
        unlock2 = false;
    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + scoreInt;

        if(scoreInt >= 50)
        {
            unlock1 = false;
            unlock2 = true;
        }
			
	}

    public static void IncreaseScore(int Amount)
    {
        scoreInt += Amount;
    }
}
