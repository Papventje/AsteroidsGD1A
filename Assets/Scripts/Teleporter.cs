using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class Teleporter : MonoBehaviour {

    private bool tpSpace = false;

    public AudioClip teleport;
    private AudioSource source;

    public Transform tp1;
    public Transform platform1;

    public ParticleSystem tp;
 
    public Text teleportText;

    public PlayerMovement player;

    void Start()
    {
        source = GetComponent<AudioSource>();

        GameObject p = GameObject.FindGameObjectWithTag("Player");
        player = p.GetComponent<PlayerMovement>();

        teleportText.text = "Press Space To Teleport";
        teleportText.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tpSpace = true;
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            tpSpace = false;
        }

    }

	void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("TP1"))
        {
            teleportText.enabled = true;
        }
        else
        {
            teleportText.enabled = false;
        }
        if (other.CompareTag("TP1") && tpSpace == true)
        {
            transform.position = new Vector3(platform1.position.x, platform1.position.y + 0.2f, platform1.position.z);
            source.PlayOneShot(teleport, 1f);
            tp.Play();
        }
    }
}