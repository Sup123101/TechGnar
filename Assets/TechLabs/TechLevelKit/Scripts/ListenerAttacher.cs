using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListenerAttacher : MonoBehaviour {
	public GameObject ear1;
	public GameObject ear2;
	// Use this for initialization
	void Start () {
		


			ear2.AddComponent<AkAudioListener> ();
		
			ear1.AddComponent<AkAudioListener> ();
		
		//print ("tried to add listener");
	}


	
	// Update is called once per frame
	void Update () {
		gameObject.SetActive(true);
	}
}
