using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlayerHealth : MonoBehaviour {

    public static int playerLives;
    public Text Lives;
    public ParticleSystem spawn;

    public float sec = 5f;

    public AudioClip playerDeath;
    public AudioClip pickup2;
    private AudioSource source;

    private GameObject shield;

    void Start()
    {
        spawn.Play();
        source = GetComponent<AudioSource>();
        playerLives = 3;
        shield = GameObject.FindGameObjectWithTag("Shield");
        shield.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            spawn.Play();
            playerLives -= 1;
            source.PlayOneShot(playerDeath, 1f);
            Respawn();
            StartCoroutine(RespawnTime());
            spawn.Play();

            //Debug.Log(playerLives);
        }
        if (other.gameObject.CompareTag("Enemy2"))
        {
            playerLives -= 1;
            Respawn();
            StartCoroutine(RespawnTime());

            //Debug.Log(playerLives);
        }
        if (other.gameObject.CompareTag("Enemy3"))
        {
            playerLives -= 1;
            Respawn();
            StartCoroutine(RespawnTime());

            //Debug.Log(playerLives);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PU2"))
        {
            source.PlayOneShot(pickup2, 1f);
            Destroy(other.gameObject);
            StartCoroutine(RespawnTime());
        }
    }

    void Update()
    {
        Lives.text = "Lives: " + playerLives;
        if(playerLives <= 0)
        {
            Score.scoreInt = 0;
            SceneManager.LoadScene("End");
        }
    }
    

    void Respawn()
    {
        transform.position = new Vector3(0, 1.06f,0);
    }

    IEnumerator RespawnTime()
    {
        shield.SetActive(true);
        yield return new WaitForSeconds(sec);
        shield.SetActive(false);

    }
}
