using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject spawnpoint1;
    public GameObject spawnpoint2;
    public GameObject spawnpoint3;

    public static float minSpawnTime = 10f;
    public static float maxSpawnTime = 10f;

    public int amount;

    private int spawnRateTime;

    private Vector3 spawnPoint;

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        amount = enemies.Length;

        if (amount != 5)
        {
            InvokeRepeating("spawnEnemy", Random.Range(minSpawnTime, maxSpawnTime), 10f);
        }
    }
    void spawnEnemy()
    {
        Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length - 1)], spawnpoint1.transform.position, Quaternion.identity);
        CancelInvoke();
        Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length )], spawnpoint2.transform.position, Quaternion.identity);
        CancelInvoke();
        Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length + 1)], spawnpoint3.transform.position, Quaternion.identity);
        CancelInvoke();

    }

}
