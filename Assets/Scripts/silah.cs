using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class silah : MonoBehaviour
{
    public GameObject mermi1;
    public Transform barrel;
    private float time1;
    private bool isshooted=false;
    private float delay;
    public float delaytime;
    public ParticleSystem shoteffect;
    void Update()
    {
        //timer
        time1 = time1 + Time.deltaTime;
        delay = delay + Time.deltaTime;

        if (Input.GetKeyDown("space")){
            if (!isshooted)
            {
                //clone mermi
                Instantiate(mermi1, barrel.position, barrel.rotation);
                //clone particle
                Instantiate(shoteffect, barrel.position, barrel.rotation);
                isshooted = true;
            }
            else
            {
                if (delay > delaytime)
                {
                    isshooted = false;
                    delay = 0;
                }
            }
        }

    }
}
