using UnityEngine;
using System.Collections;

public class SpawnPickups : MonoBehaviour {

    public Transform[] spawnPoints;
    private float spawnTime = 15f;

    public GameObject[] Pickup;


	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnPickup", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnPickup()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);

        int objectIndex = Random.Range(0, Pickup.Length);

        Instantiate(Pickup[objectIndex], spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
    }


}
