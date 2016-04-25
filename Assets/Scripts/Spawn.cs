using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    public GameObject[] enemies;
    public int amount;

    private Vector3 spawnPoint;

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        amount = enemies.Length;

        if (amount != 15)
        {
            InvokeRepeating("spawnEnemy", 5, 10f);
        }
    }
     void spawnEnemy()
    {
        spawnPoint.x = 0f;
        spawnPoint.y = 5f;
        spawnPoint.z = 10f;

        Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length  -1)], spawnPoint, Quaternion.identity);
        CancelInvoke();
        
    }
	
}
