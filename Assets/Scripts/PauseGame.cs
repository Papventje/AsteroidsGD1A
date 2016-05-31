using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

    public Transform canvas;
    public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();  
        }
	}

    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            player.GetComponent<Shooting>().enabled = false;
            player.GetComponent<PlayerMovement>().enabled = false;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            player.GetComponent<Shooting>().enabled = true;
            player.GetComponent<PlayerMovement>().enabled = true;
        }
    }

    public void Mute()
    {
        //mute audio
    }

    public void Exit()
    {
        Application.Quit();
    }
}
