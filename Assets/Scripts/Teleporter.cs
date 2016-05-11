using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

    private bool tpSpace = false;

    public Transform tp1;
    public Transform tp2;
    public Transform platform1;
    public Transform platform2;

    public PlayerMovement player;
    private int waitTime = 2;

    void Start()
    {
        GameObject p = GameObject.FindGameObjectWithTag("Player");
        player = p.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            tpSpace = true;
            Debug.Log("True");
        }
        if(Input.GetKeyUp(KeyCode.Space))
        {
            tpSpace = false;
            Debug.Log("False");
        }

    }

	void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("TP1") && tpSpace == true)
        {
            transform.position = new Vector3(platform1.position.x, platform1.position.y + 2.67f, platform1.position.z);
            //cooldown()
        }
        if (other.CompareTag("TP2") && tpSpace == true)
        {
            transform.position = new Vector3(platform2.position.x, platform2.position.y + 2.67f, platform2.position.z);
            //cooldown()

        }
    }
}
