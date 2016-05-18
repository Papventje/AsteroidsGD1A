using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public Missile missile;
    public Missile missile2;
    public Transform muzzle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && GameObject.Find("ScoreManager").GetComponent<Score>().unlock1 == true)
        {
            //Debug.Log("PEWPEWPEWPEPW");
            Shoot();
        }
        if (Input.GetMouseButtonDown(0) && GameObject.Find("ScoreManager").GetComponent<Score>().unlock2 == true)
        {
            Shoot2();
        }
	}

    private void Shoot()
    {
        Missile newMissile = Instantiate(missile, muzzle.position, muzzle.rotation) as Missile;
    }

    private void Shoot2()
    {
        Missile newMissile2 = Instantiate(missile2, muzzle.position, muzzle.rotation) as Missile;
    }
}
