using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{

    private float speed = 20;

    void Start()
    {
        Destroy(gameObject, 3f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}