using UnityEngine;
using System.Collections;
using System;

public class FlickeringLight : MonoBehaviour {

    public Light testLight;
    //public float minWaitTime = 0.1f;
    //public float maxWaitTime = 0.5f;

    // Use this for initialization
    void Start () {
        testLight = GetComponent<Light>();
        StartCoroutine(Flashing());
	}

    private IEnumerator Flashing()
    {
        while (true) {
            yield return new WaitForSeconds(1f);
            testLight.enabled = !testLight.enabled;
        }
    }
    
}
