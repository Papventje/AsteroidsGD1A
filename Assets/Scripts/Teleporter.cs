using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

    private bool tpSpace = false;

    public Transform tp1;
    public Transform tp2;

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
            transform.position = new Vector3(tp2.position.x, tp2.position.y + 2.67f, tp2.position.z + 2);
            //cooldown()
        }
        if (other.CompareTag("TP2") && tpSpace == true)
        {
            transform.position = new Vector3(tp1.position.x, tp1.position.y + 2.67f, tp1.position.z + 2);
            //cooldown()

        }
    }
}
