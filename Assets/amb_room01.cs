using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amb_room01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AkSoundEngine.PostEvent("amb_room1", this.gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
