using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomAmbience : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AkSoundEngine.PostEvent("amb_rooms", this.gameObject);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
