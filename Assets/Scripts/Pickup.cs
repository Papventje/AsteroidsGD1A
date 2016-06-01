using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

    private float rotateSpeed = 100f;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 7.5f);
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
	}

    IEnumerator PickupMovement()
    {
        yield return new WaitForSeconds(2);
    }
}
