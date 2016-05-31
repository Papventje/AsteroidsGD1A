using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{

    public Rigidbody rb;
    public float thrust = 200;
    private bool explosionCheck = false;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * thrust);

        explosionCheck = false;

        StartCoroutine(Explosion());
    }

    void OnTriggerEnter(Collider Other)
    {
        if (Other.CompareTag("Enemy")&& explosionCheck == true)
        {
            Destroy(Other.gameObject);
        }
    }

    void Update()
    {

    }

    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(2);
        explosionCheck = true;
        Destroy(gameObject);
    }
}
  

