using UnityEngine;
using System.Collections;

public class Spawn2 : MonoBehaviour
{
	public GameObject[] enemies;
	public int amount;

	private int spawnRateTime;

	private Vector3 spawnPoint;

	void Update()
	{
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
		amount = enemies.Length;

        if (amount != 5)
        {
            InvokeRepeating("spawnEnemy", 5f /*-(Score.scoreInt / 150)*/, 10f);
        }
    }
	void spawnEnemy()
	{
		spawnPoint.x = 43f;
		spawnPoint.y = 5f;
		spawnPoint.z = -37f;

		Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length  -1)], spawnPoint, Quaternion.identity);
		CancelInvoke();

	}

}
