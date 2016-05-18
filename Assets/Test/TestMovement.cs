using UnityEngine;
using System.Collections;

public class TestMovement : MonoBehaviour {
    
    private float rotationSpeed;
    private Rigidbody rb;
    private Vector3 _direction;
    private float speed = 5;
    //private float horizonalInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        _direction = new Vector3(x, 0f, z);
        /* if (Input.GetKeyDown(KeyCode.W))
         {
             rb.transform.Rotate(0, 45, 0);
         }*/
        
    }

    void FixedUpdate()
    {
        //rb.MoveRotation(rb.rotation * Quaternion.Euler(0f, horizonalInput * rotationSpeed, 0f));
        Vector3 velocity = _direction.normalized * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + velocity);
    }
}
