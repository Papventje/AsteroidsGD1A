using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public int playerLives;
    public Text Lives;
    public float sec = 5f;

    private GameObject shield;

    void Start()
    {
        playerLives = 3;
        shield = GameObject.FindGameObjectWithTag("Shield");
        shield.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            playerLives -= 1;
            Respawn();
            shield.SetActive(true);
            StartCoroutine(RespawnTime());

            //Debug.Log(playerLives);
        }
    }

    void Update()
    {
        Lives.text = "Lives: " + playerLives;
        if(playerLives == 0)
        {
            SceneManager.LoadScene("End");
        }
    }
    

    void Respawn()
    {
        transform.position = new Vector3(0, 1.06f,0);
    }

    IEnumerator RespawnTime()
    {
        yield return new WaitForSeconds(sec);
        shield.SetActive(false);

    }
}
