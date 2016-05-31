using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class EnemyHealth : MonoBehaviour
{
    public AudioClip enemyDeath;
    private AudioSource source;

    public float enemyHealth;

    void Start()
    {

        source = GetComponent<AudioSource>();
        enemyHealth = (60f + Score.scoreInt / 5);
    }

    void Update()
    {
        if (enemyHealth <= 0)
        {
            source.PlayOneShot(enemyDeath, 1f);
            Destroy(gameObject);
            Score.IncreaseScore(10);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            enemyHealth -= 10;
        }
        if (other.CompareTag("Missile2"))
        {
            enemyHealth -= 15;
        }
    }
    

}
    

