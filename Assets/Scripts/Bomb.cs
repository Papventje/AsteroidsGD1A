using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour
{

    public Rigidbody rb;
    public float thrust = 200;
    private bool explosionCheck = false;


    public ParticleSystem explosion;

    void Start()
    { 
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * thrust);

        StartCoroutine(Explosion());
        explosionCheck = false;
    }

    void Update()
    {

    }

    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(1);
        explosion.Play();
        explosionCheck = true;
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
  

