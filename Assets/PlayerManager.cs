﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    //player health
    public static int health = 100;
    //amount of enemies nearby
    private GameObject cameraC;
    public static int enemiesnearby = 0;
    private Rigidbody rc;
    public bool hasdied = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//        print("enemies around" + enemiesnearby);
		if (health <= 0 && hasdied == false)
        {
            hasdied = true;
            cameraC = GameObject.Find("Camera (eye)");
            if (cameraC == null)
            {
                cameraC = GameObject.Find("Camera");
            }
            cameraC.SetActive(false);
           
        }
	}
}
