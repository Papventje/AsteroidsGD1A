using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class StartMenu : MonoBehaviour {
    
    public Button startButton;

    void Start()
    {
        startButton = startButton.GetComponent<Button>();
    }

    public void StartLevel()
    {
        SceneManager.LoadScene("Main");
    }
}
