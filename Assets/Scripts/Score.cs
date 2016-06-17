using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    public Text scoreText;
    public Text highScoreText;
    public static int scoreInt = 0;
    public static int highScore = 0;
    string highScoreKey = "HighScore";

    public bool unlock1 = true;
    public bool unlock2 = false;
    public bool unlock3 = false;
    public bool unlock4 = false;
    public bool unlock5 = false;

    private GameObject respawn2;
    private GameObject respawn3;


    // Use this for initialization
    void Start () {
        respawn2 = GameObject.FindGameObjectWithTag("Respawn2");
        respawn2.SetActive(false);
        respawn3 = GameObject.FindGameObjectWithTag("Respawn3");
        respawn3.SetActive(false);

        highScore = PlayerPrefs.GetInt(highScoreKey, 0);

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
        highScoreText.text = "Highscore : " + highScore;

        if(scoreInt >= 100)
        {
            unlock1 = false;
            unlock2 = true;
            Spawn.minSpawnTime = 3f;
            Spawn.maxSpawnTime = 5f;
        }
        if(scoreInt >= 250)
        {
            unlock2 = false;
            unlock3 = true;
            respawn2.SetActive(true);
        }
        if(scoreInt >= 500)
        {
            unlock3 = false;
            unlock4 = true;
            respawn3.SetActive(true);
        }
        if(scoreInt > highScore)
        {
            PlayerPrefs.SetInt(highScoreKey, scoreInt);
            PlayerPrefs.Save();
        }
    }

    public static void IncreaseScore(int Amount)
    {
        scoreInt += Amount;
    }
}
