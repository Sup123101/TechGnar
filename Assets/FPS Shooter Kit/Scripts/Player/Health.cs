using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

	public int health = 100;
    bool healthSoundSet = false;
	//public Text textHealth;
	//public RawImage Blood;


	void Start ()
	{

		//textHealth.text = health + "%";

	}


	public void SetDamage (int damage)
	{
	
		health = health - damage;
        PlayerManager.health = health;

		/*if (health == 20) {

			Blood.color = new Color (1f, 1f, 1f, 0.20f);
		}

		if (health < 20) {

			Blood.color = new Color (1f, 1f, 1f, 0.2f + ((0.8f / 20f) * (20f - health)));

		} */
        
	}
    private void Update()
    {
        if (healthSoundSet == false)
        {
            if (health <= 40)
            {
                healthSoundSet = true;
                AkSoundEngine.PostEvent("Heartbeat", this.gameObject);
            }
        }

    }

    void FixedUpdate ()
	{
        /*
		textHealth.text = health + "%";

		if (health > 20) {
			Blood.color = new Color (1f, 1f, 1f, 0.0f);
		}
        */
        
	}

}
