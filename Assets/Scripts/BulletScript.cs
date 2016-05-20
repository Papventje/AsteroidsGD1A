using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{

    private float speed = 20;

    void Start()
    {
        Destroy(gameObject, 10f);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
