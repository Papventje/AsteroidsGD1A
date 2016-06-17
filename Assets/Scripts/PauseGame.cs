using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PauseGame : MonoBehaviour {

    public Transform canvas;
    public Transform player;

    public static AudioSource source;

    // Use this for initialization
    void Start () {
        source = GetComponent<AudioSource>();
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
