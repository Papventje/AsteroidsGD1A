using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public Missile missile;
    public Missile missile2;
    public Missile missile3;
    public Missile missile4;

    public Transform muzzle;
    public Transform doubleMuzzle1;
    public Transform doubleMuzzle2;
    public Transform tripleMuzzle1;
    public Transform tripleMuzzle2;
    public Transform tripleMuzzle3;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) && GameObject.Find("ScoreManager").GetComponent<Score>().unlock1 == true)
        {
            Debug.Log("PEWPEWPEWPEPW");
            Shoot();
        }
        if (Input.GetMouseButtonDown(0) && GameObject.Find("ScoreManager").GetComponent<Score>().unlock2 == true)
        {
            Shoot2();
        }
        if (Input.GetMouseButtonDown(0) && GameObject.Find("ScoreManager").GetComponent<Score>().unlock3 == true)
        {
            Shoot3();
        }
        if (Input.GetMouseButtonDown(0) && GameObject.Find("ScoreManager").GetComponent<Score>().unlock4 == true)
        {
            Shoot4();
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

    private void Shoot3()
    {
        Missile newDoubleShot1 = Instantiate(missile3, doubleMuzzle1.position, doubleMuzzle1.rotation) as Missile;
        Missile newDoubleShot2 = Instantiate(missile3, doubleMuzzle2.position, doubleMuzzle2.rotation) as Missile;
    }
    private void Shoot4()
    {
        Missile newTripleShot1 = Instantiate(missile4, tripleMuzzle1.position, tripleMuzzle1.rotation) as Missile;
        Missile newTripleShot2 = Instantiate(missile4, tripleMuzzle2.position, tripleMuzzle2.rotation) as Missile;
        Missile newTripleShot3 = Instantiate(missile4, tripleMuzzle3.position, tripleMuzzle3.rotation) as Missile;
    }
}
