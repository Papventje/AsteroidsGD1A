using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

    public bool respawn = false;

	void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy")&& respawn)
        {

            Destroy(other.gameObject);
            respawn = false;
        }
    }
}
