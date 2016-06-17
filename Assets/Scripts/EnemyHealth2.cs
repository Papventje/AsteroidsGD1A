using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class EnemyHealth2 : MonoBehaviour {

    public AudioClip enemyHit;
    public AudioClip Death;
    private AudioSource source;

	private float enemyHealth2;


	void Start () {

		source = GetComponent<AudioSource> ();
		enemyHealth2 = 120;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyHealth2 <= 0) {
            PauseGame.source.PlayOneShot(Death, 1f);
            Destroy (gameObject);
			Score.IncreaseScore (20);
		}
	
	}

	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Missile")) {
            source.PlayOneShot(enemyHit, 1f);
            enemyHealth2 -= 10;
		}
		if (other.CompareTag ("Missile2")) {
            source.PlayOneShot(enemyHit, 1f);
            enemyHealth2 -= 15;
		}
	}


}
