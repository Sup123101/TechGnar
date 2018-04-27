using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeVive : MonoBehaviour {
    public GameObject ParticleHited;
    // Use this for initialization
    public Rigidbody rb;
    void Start () {
        
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "HitedEnemy")
        {
            GameObject HitBlood = Instantiate(ParticleHited);
            HitBlood.transform.position = other.transform.position;
            HitBlood.transform.rotation = other.transform.rotation;
            EnemyDamage enemDamage = other.gameObject.GetComponent<EnemyDamage>();
            enemDamage.SetDamage(100);
        }
        print("meleed enemy");
    }
     void triggerStay(Collision collision)
    {
        
    }

    // Update is called once per frame
    void Update () {
        print("rb i " + rb.angularVelocity.magnitude);
        print("rb i " + rb.velocity.magnitude);
    }
}
    

