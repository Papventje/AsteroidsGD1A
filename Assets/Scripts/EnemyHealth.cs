using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{

    public float enemyHealth = 100f;

    void Start()
    {
        enemyHealth = 100f;
    }

    void Update()
    {
        if(enemyHealth <= 0)
        {
            Destroy(gameObject);
        }       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Missile"))
        {
            enemyHealth -= 10;
        }
    }
}
    

