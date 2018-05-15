using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	public void deathCry()
    {
        if (gameObject.name == "Fat")
        {
            AkSoundEngine.PostEvent("Parazite_Fat_Deathcry", this.gameObject);
        }
        if (gameObject.name == "Parazid")
        {
            AkSoundEngine.PostEvent("Parazite_Deathcry", this.gameObject);
        }
        if (gameObject.name == "Parazite_slider")
        {
            AkSoundEngine.PostEvent("Parazite_Slider_Deathcry", this.gameObject);
        }
        if (gameObject.name == "Parazite_spider")
        {
            AkSoundEngine.PostEvent("Parazite_Spider_Deathcry", this.gameObject);
        }
    }
    public void hurt()
    {
        if(gameObject.name == "Fat")
        {
            AkSoundEngine.PostEvent("Parazite_Fat_Hurt", this.gameObject);
        }
  
        if (gameObject.name == "Parazid")
        {
            AkSoundEngine.PostEvent("Parazite_Hurt", this.gameObject);
        }
        if (gameObject.name == "Parazite_slider")
        {
            AkSoundEngine.PostEvent("Parazite_Slider_Hurt", this.gameObject);
        }
        if (gameObject.name == "Parazite_spider")
        {
            AkSoundEngine.PostEvent("Parazite_Spider_Hurt", this.gameObject);
        }
    }
    public void behAttack()
    {
        if (gameObject.name == "Fat")
        {
            AkSoundEngine.PostEvent("Parazite_Fat_Attack", this.gameObject);
        }

        if (gameObject.name == "Parazid")
        {
            AkSoundEngine.PostEvent("Parazite_Attack", this.gameObject);
}
        if (gameObject.name == "Parazite_slider")
        {
            AkSoundEngine.PostEvent("Parazite_Slider_Attack", this.gameObject);
        }
        if (gameObject.name == "Parazite_spider")
        {
            AkSoundEngine.PostEvent("Parazite_Spider_Attack", this.gameObject);
        }
    }
    public void behAttack2()
    {
        if (gameObject.name == "Fat")
        {
            AkSoundEngine.PostEvent("Parazite_Fat_Attack", this.gameObject);
        }

        if (gameObject.name == "Parazid")
        {
            AkSoundEngine.PostEvent("Parazite_Attack", this.gameObject);
}
        if (gameObject.name == "Parazite_slider")
        {
            AkSoundEngine.PostEvent("Parazite_Slider_Attack", this.gameObject);
        }
        if (gameObject.name == "Parazite_spider")
        {
            AkSoundEngine.PostEvent("Parazite_Spider_Attack", this.gameObject);
        }
    }
    public void idle()
    {
        if (gameObject.name == "Fat")
        {
            AkSoundEngine.PostEvent("Parazite_Fat_Idle", this.gameObject);
        }

        if (gameObject.name == "Parazid")
        {
            AkSoundEngine.PostEvent("Parazite_Idle", this.gameObject);
}
        if (gameObject.name == "Parazite_slider")
        {
            AkSoundEngine.PostEvent("Parazite_Slider_Idle", this.gameObject);
        }
        if (gameObject.name == "Parazite_spider")
        {
            AkSoundEngine.PostEvent("Parazite_Spider_Idle", this.gameObject);
        }
    }
    public void idle_other()
    {
        if (gameObject.name == "Fat")
        {
            AkSoundEngine.PostEvent("Parazite_Fat_Idle", this.gameObject);
        }

        if (gameObject.name == "Parazid")
        {
            AkSoundEngine.PostEvent("Parazite_Idle", this.gameObject);
}
        if (gameObject.name == "Parazite_slider")
        {
            AkSoundEngine.PostEvent("Parazite_Slider_Idle", this.gameObject);
        }
        if (gameObject.name == "Parazite_spider")
        {
            AkSoundEngine.PostEvent("Parazite_Spider_Idle", this.gameObject);
        }
    }
    public void Shout()
    {
        if (gameObject.name == "Fat")
        {
            AkSoundEngine.PostEvent("Parazite_Fat_Roar", this.gameObject);
        }

        if (gameObject.name == "Parazid")
        {
            AkSoundEngine.PostEvent("Parazite_Roar", this.gameObject);
}
        if (gameObject.name == "Parazite_slider")
        {
            AkSoundEngine.PostEvent("Parazite_Slider_Roar", this.gameObject);
        }
        if (gameObject.name == "Parazite_spider")
        {
            AkSoundEngine.PostEvent("Parazite_Spider_Roar", this.gameObject);
        }
    }
    public void Walk()
    {
        if (gameObject.name == "Fat")
        {
            AkSoundEngine.PostEvent("Parazite_Fat_Footsteps", this.gameObject);
        }

        if (gameObject.name == "Parazid")
        {
            AkSoundEngine.PostEvent("Parazite_Footsteps", this.gameObject);
}
        if (gameObject.name == "Parazite_slider")
        {
            AkSoundEngine.PostEvent("Parazite_Slider_Footsteps", this.gameObject);
        }
        if (gameObject.name == "Parazite_spider")
        {
            AkSoundEngine.PostEvent("Parazite_Spider_Footsteps", this.gameObject);
        }
    }
    public void Run()
    {
        if (gameObject.name == "Fat")
        {
            AkSoundEngine.PostEvent("Parazite_Fat_Footsteps", this.gameObject);
        }
        if (gameObject.name == "Parazid")
        {
            AkSoundEngine.PostEvent("Parazite_Footsteps", this.gameObject);
        }
        if (gameObject.name == "Parazite_slider")
        {
            AkSoundEngine.PostEvent("Parazite_Slider_Footsteps", this.gameObject);
        }
        if (gameObject.name == "Parazite_spider")
        {
            AkSoundEngine.PostEvent("Parazite_Spider_Footsteps", this.gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
