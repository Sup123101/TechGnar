using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPillars : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AkSoundEngine.PostEvent("rotating_pillar", this.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
