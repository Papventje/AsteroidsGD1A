using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class EnemyHealth3 : MonoBehaviour {

    public AudioClip enemyHit;
    public AudioClip Death;
    private AudioSource source;

	private float enemyHealth3;
	private GameObject enemy1;

	void Start () {
		source = GetComponent<AudioSource> ();
		enemy1 = GameObject.FindGameObjectWithTag ("Enemy");
		enemyHealth3 = 180;

		
	
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHealth3 <= 0) {
            PauseGame.source.PlayOneShot(Death, 1f);
            Instantiate (enemy1, gameObject.transform.position, Quaternion.identity);
			Instantiate (enemy1, gameObject.transform.position, Quaternion.identity);
			Destroy (gameObject);
			Score.IncreaseScore (30);
		}
	
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Missile"))
		{
            source.PlayOneShot(enemyHit, 1f);
            enemyHealth3 -= 10;
		}
		if (other.CompareTag("Missile2"))
		{
            source.PlayOneShot(enemyHit, 1f);
            enemyHealth3 -= 15;
		}
	}
}
