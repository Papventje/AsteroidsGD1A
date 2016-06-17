using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public bool movement = true;

    public AudioClip pickup1;
    public AudioClip pickup3;
    public AudioClip bump;
    private AudioSource source;

    private Rigidbody _rigidbody;
    private Vector3 _direction;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (movement) {
            float x = Input.GetAxisRaw("Horizontal");
            float z = Input.GetAxisRaw("Vertical");
            _direction = new Vector3(x, 0f, z);

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Plane plane = new Plane(Vector3.up, Vector3.zero);
            float distance;

            if (plane.Raycast(ray, out distance))
            {
                Vector3 point = ray.GetPoint(distance);
                Vector3 adjustedHeightPoint = new Vector3(point.x, transform.position.y, point.z);
                transform.LookAt(adjustedHeightPoint);
            }

        }
    }

    void FixedUpdate()
    {
        Vector3 velocity = _direction.normalized * speed * Time.fixedDeltaTime;
        _rigidbody.MovePosition(_rigidbody.position + velocity);

    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Crate"))
        {
            source.PlayOneShot(bump, 1f);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PU1"))
        {
            source.PlayOneShot(pickup1, 1f);
            Destroy(other.gameObject);
            PlayerHealth.playerLives += 1;
        }
        if (other.CompareTag("PU3"))
        {
            source.PlayOneShot(pickup3, 1f);
            Destroy(other.gameObject);
            StartCoroutine(SpeedBuff());
        }
    }

    IEnumerator SpeedBuff()
    {
        speed += 3;
        yield return new WaitForSeconds(3f);
        speed -= 3;
    }

}
