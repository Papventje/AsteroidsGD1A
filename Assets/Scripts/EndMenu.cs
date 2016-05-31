using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EndMenu : MonoBehaviour {

    public Button restartButton;

    public void RestartLevel()
    {
        SceneManager.LoadScene("Main");
    }
}
