using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{


    public float enemyHealth;

    void Start()
    {
        enemyHealth = 120f;
    }

    void Update()
    {
        if (enemyHealth <= 0)
        {
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
            enemyHealth -= 20;
        }
    }
    

}
    

