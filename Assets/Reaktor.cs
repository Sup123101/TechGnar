﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reaktor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		AkSoundEngine.PostEvent("reaktor", this.gameObject);
	}

	// Update is called once per frame
	void Update () {
		
	}
}