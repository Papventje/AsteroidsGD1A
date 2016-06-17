using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartMenu : MonoBehaviour {
    
    public Button startButton;
    public Button nextButton;

    public Image next;
    public Image howTo;

    void Start()
    {
        startButton = startButton.GetComponent<Button>();
        nextButton = nextButton.GetComponent<Button>();

        howTo = howTo.GetComponent<Image>();

        next.enabled = false;
        howTo.enabled = false;
    }

    public void StartLevel()
    {
        next.enabled = true;
        howTo.enabled = true;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Main");
    }
}
