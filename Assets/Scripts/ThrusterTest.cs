using UnityEngine;
using System.Collections;

public class ThrusterTest : MonoBehaviour {

    private Rigidbody rb;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //rb.transform.eulerAngles = new Vector3(0, 0,-30);
        }
	}
}
