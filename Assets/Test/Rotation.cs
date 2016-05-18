using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

    [SerializeField]
    private int rotateSpeed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
	void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.eulerAngles = new Vector3(0, 90, 0);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.eulerAngles = new Vector3(0, 270, 0);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        if(Input.GetKey(KeyCode.W)&& Input.GetKeyDown(KeyCode.D))
        {
            rb.transform.eulerAngles = new Vector3(0, 45, 0);
        }
        
        
    }
}
