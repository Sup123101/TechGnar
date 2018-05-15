using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steam_sound : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        AkSoundEngine.PostEvent("steam", this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}