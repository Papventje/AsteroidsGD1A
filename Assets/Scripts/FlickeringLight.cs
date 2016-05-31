using UnityEngine;
using System.Collections;
using System;

public class FlickeringLight : MonoBehaviour {

    public Light greenLight;
    private float duration;
    //public float minWaitTime = 0.1f;
    //public float maxWaitTime = 0.5f;

    //public float duration = 1.0f;
    //public Color color0 = Color.red;
    //public Color color1 = Color.yellow;

    // Use this for initialization
    void Start () {
        greenLight = GetComponent<Light>();
        StartCoroutine(Flashing());
	}

    private IEnumerator Flashing()
    {
        while (true) {
            yield return new WaitForSeconds(duration);
            greenLight.enabled = !greenLight.enabled;
        }
    }

    void Update()
    {
        if(PlayerHealth.playerLives >= 3)
        {
            greenLight.color = Color.green;
            duration = 1f;
        }
        if(PlayerHealth.playerLives == 2)
        {
            greenLight.color = Color.yellow;
            duration = .75f;
        }
        if(PlayerHealth.playerLives == 1)
        {
            greenLight.color = Color.red;
            duration = .5f;
        }
        
        //float t = Mathf.PingPong(Time.time, duration) / duration;
        //greenLight.color = Color.Lerp(color0, color1, t);
    }
    
}
