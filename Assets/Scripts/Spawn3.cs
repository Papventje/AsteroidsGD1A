using UnityEngine;
using System.Collections;

public class Spawn3 : MonoBehaviour
{
	public GameObject[] enemies;
	public int amount;

	private int spawnRateTime;

	private Vector3 spawnPoint;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.P))
		{
			Score.scoreInt += 220;
		}
		enemies = GameObject.FindGameObjectsWithTag("Enemy");
		amount = enemies.Length;

		if (amount != 15)
		{
			InvokeRepeating("spawnEnemy", 10f -(Score.scoreInt / 150), 10f);
		}
	}
	void spawnEnemy()
	{
		spawnPoint.x = -33f;
		spawnPoint.y = 5f;
		spawnPoint.z = -37f;

		Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length  -1)], spawnPoint, Quaternion.identity);
		CancelInvoke();

	}

}
