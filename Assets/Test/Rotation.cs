using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.transform.Rotate(0, 90, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.transform.Rotate(0, -90, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.transform.Rotate(0, 270, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.transform.Rotate(0, -270, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.transform.Rotate(0, 180, 0);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.transform.Rotate(0, -180, 0);
        }
    }
}
