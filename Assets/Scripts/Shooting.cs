using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public Missile missile;
    public Transform muzzle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("PEWPEWPEWPEPW");
            Shoot();
        }
	}

    private void Shoot()
    {
        Missile newMissile = Instantiate(missile, muzzle.position, muzzle.rotation) as Missile;
    }
}
