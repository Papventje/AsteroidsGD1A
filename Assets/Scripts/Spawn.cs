using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour
{
    public GameObject enemy;
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
        enemy = GameObject.FindGameObjectWithTag("Enemy");

        if (amount != 5)
        {
            InvokeRepeating("spawnEnemy", Random.Range(minSpawnTime, maxSpawnTime), 10f);
        }
    }
    void spawnEnemy()
    {
        Instantiate(enemy, spawnpoint1.transform.position, Quaternion.identity);
        CancelInvoke();
        Instantiate(enemy, spawnpoint2.transform.position, Quaternion.identity);
        CancelInvoke();
        Instantiate(enemy, spawnpoint3.transform.position, Quaternion.identity);
        CancelInvoke();

    }

}
