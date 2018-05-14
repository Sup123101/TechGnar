using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public attack(){
		if (gameObject.name == "Parazite") {
			AkSoundEngine.PostEvent ("Parazite_Attack", this.gameObject);
		}
		if (gameObject.name == "Parazite_Fat") {
			AkSoundEngine.PostEvent ("Parazite_Fat_Attack", this.gameObject);
		}
		if (gameObject.name == "Parazite_Slider") {
			AkSoundEngine.PostEvent ("Parazite_Slider_Attack", this.gameObject);
		}
		if (gameObject.name == "Parazite_Spider") {
			AkSoundEngine.PostEvent ("Parazite_Spider_Attack", this.gameObject);
		}
	}
		public void GetHit(){
			if (gameObject.name == "Parazite") {
				AkSoundEngine.PostEvent ("Parazite_Hurt", this.gameObject);
			}
			if (gameObject.name == "Parazite_Fat") {
			AkSoundEngine.PostEvent ("Parazite_Fat_Hurt", this.gameObject);
			}
			if (gameObject.name == "Parazite_Slider") {
			AkSoundEngine.PostEvent ("Parazite_Slider_Hurt", this.gameObject);
			}
			if (gameObject.name == "Parazite_Spider") {
			AkSoundEngine.PostEvent ("Parazite_Spider_Hurt", this.gameObject);
			}
}
	public void idle(){
		if (gameObject.name == "Parazite") {
			AkSoundEngine.PostEvent ("Parazite_Idle", this.gameObject);
		}
		if (gameObject.name == "Parazite_Fat") {
			AkSoundEngine.PostEvent ("Parazite_Fat_Idle", this.gameObject);
		}
		if (gameObject.name == "Parazite_Slider") {
			AkSoundEngine.PostEvent ("Parazite_Slider_Idle", this.gameObject);
		}
		if (gameObject.name == "Parazite_Spider") {
			AkSoundEngine.PostEvent ("Parazite_Spider_Idle", this.gameObject);
		}
	}

	public void dead(){
		if (gameObject.name == "Parazite") {
			AkSoundEngine.PostEvent ("Parazite_Deathcry", this.gameObject);
		}
		if (gameObject.name == "Parazite_Fat") {
			AkSoundEngine.PostEvent ("Parazite_Fat_Deathcry", this.gameObject);
		}
		if (gameObject.name == "Parazite_Slider") {
			AkSoundEngine.PostEvent ("Parazite_Slider_Deathcry", this.gameObject);
		}
		if (gameObject.name == "Parazite_Spider") {
			AkSoundEngine.PostEvent ("Parazite_Spider_Deathcry", this.gameObject);
		}
	}
}
	
