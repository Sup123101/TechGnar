using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turbineFan_sound : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        AkSoundEngine.PostEvent("turbine_fan", this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
