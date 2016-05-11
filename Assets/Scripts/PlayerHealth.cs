using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public int playerLives;

    void Start()
    {
        playerLives = 3;
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            playerLives -= 1;
            Respawn();
            gameObject.GetComponent<Respawn>().respawn = false;
            Debug.Log(playerLives);
        }
    }

    void Update()
    {
        if(playerLives == 0)
        {
            SceneManager.LoadScene("End");
        }
    }

    void Respawn()
    {
        transform.position = new Vector3(0.5f, 2.2f,0);
    }
}
