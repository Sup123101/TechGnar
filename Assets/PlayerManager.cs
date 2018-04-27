using System.Collections;
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
<<<<<<< HEAD
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print("enemies around" + enemiesnearby);
=======
    public GameObject healthcanvas;
    public GameObject bloodcanvas;
    public RawImage Blood;
    public Text textHealth;
    
    // Use this for initialization
    void Start () {
        textHealth = healthcanvas.GetComponent<Text>();
        Blood = bloodcanvas.GetComponent<RawImage>();
        textHealth.text = health + "%";
    }

    // Update is called once per frame
    void Update () {
        textHealth.text = health + "%";
        //print("enemies around" + enemiesnearby);
>>>>>>> 0c8773e48c35da7b73ae6c1eee70afe2e9c90fc0
		if (health <= 0 && hasdied == false)
        {
            hasdied = true;
            cameraC = GameObject.Find("Camera (eye)");
            if (cameraC == null)
            {
                cameraC = GameObject.Find("Camera");
            }
            cameraC.gameObject.SetActive(false);
            print("deactivating camera");
        }
<<<<<<< HEAD
	}
=======
        
        if (health > 20)
        {
            Blood.color = new Color(1f, 1f, 1f, 0.0f);
        }
        if (health < 20)
        {

            Blood.color = new Color(1f, 1f, 1f, 0.2f + ((0.8f / 20f) * (20f - health)));

        }
        
        
    }
>>>>>>> 0c8773e48c35da7b73ae6c1eee70afe2e9c90fc0
}
