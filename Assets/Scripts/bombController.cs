using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombController : MonoBehaviour
{
    public float delay = 3f;

    public GameObject explosionEffect;

    bool hasExploded = false;
    float countdown;

    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
    }

    void Explode()
    {
        
    Instantiate(explosionEffect, transform.position, transform.rotation);
            //get nearby objects
            // add force
            //damage
        
     Destroy(gameObject);
    }
}
