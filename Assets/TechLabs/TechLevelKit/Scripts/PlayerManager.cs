using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {
    //player health
    public static int health = 100;
    //amount of enemies nearby
    private GameObject cameraC;
    public static int enemiesnearby = 0;
    int previousstate = 0;//0 no monsters, 1 is nearby
    private Rigidbody rc;
    public bool hasdied = false;
	// Use this for initialization
	void Start () {
        AkSoundEngine.PostEvent("Music", this.gameObject);
        AkSoundEngine.SetState("Status", "Normal");
    }
	
	// Update is called once per frame
	void Update () {
        if (enemiesnearby > 0)
        {
            if (previousstate == 0)
            {
                previousstate = 1;
                AkSoundEngine.SetState("Status", "Attacking");

            }
        }
        if (enemiesnearby == 0)
        {
            if (previousstate == 1)
            {
                previousstate = 0;
                AkSoundEngine.SetState("Status", "Normal");

            }
        }
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
