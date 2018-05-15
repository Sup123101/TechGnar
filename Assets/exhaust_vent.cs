using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exhaust_vent : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        AkSoundEngine.PostEvent("exhaust_vent", this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
