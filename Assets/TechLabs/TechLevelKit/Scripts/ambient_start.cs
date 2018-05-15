using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambient_start : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AkSoundEngine.PostEvent ("amb_event_01", this.gameObject);
	}
	
}
