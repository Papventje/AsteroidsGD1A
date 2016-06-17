using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class EnemyHealth : MonoBehaviour
{
    public AudioClip enemyHit;
    public AudioClip Death;
    private AudioSource source;

    public float enemyHealth;

    void Start()
    {

        source = GetComponent<AudioSource>();
        enemyHealth = 60;
    }

    void Update()
    {
        if (enemyHealth <= 0)
        {
            PauseGame.source.PlayOneShot(Death, 1f);
            Destroy(gameObject);
            Score.IncreaseScore(10);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            enemyHealth -= 10;
            source.PlayOneShot(enemyHit, 1f);
        }
        if (other.CompareTag("Missile2"))
        {
            enemyHealth -= 15;
            source.PlayOneShot(enemyHit, 1f);
        }
    }
    

}
    

