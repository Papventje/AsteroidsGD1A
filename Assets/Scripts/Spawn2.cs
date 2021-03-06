﻿using UnityEngine;
using System.Collections;

public class Spawn2 : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject spawnpoint1;
    public GameObject spawnpoint2;
    public GameObject spawnpoint3;

    [SerializeField]
    private float minSpawnTime = 20f;
    [SerializeField]
    private float maxSpawnTime = 25f;

    public int amount;

    private int spawnRateTime;

    private Vector3 spawnPoint;

    void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy2");
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
        Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length - 1)], spawnpoint2.transform.position, Quaternion.identity);
        CancelInvoke();
        Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length - 1)], spawnpoint3.transform.position, Quaternion.identity);
        CancelInvoke();

    }

}
