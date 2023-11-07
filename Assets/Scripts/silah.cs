using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class silah : MonoBehaviour
{
    public GameObject mermi1;
    public Transform barrel;
    private float time1;
    public GameObject shoteffect;
    public GameObject arm;
    public float cooltimedefault;
    private float cooltime;
    void Update()
    {
        //timer
        time1 = time1 + Time.deltaTime;
        if (cooltime > 0)
        {
           cooltime = cooltime - Time.deltaTime;
        }

        if (Input.GetKeyDown("space") && cooltime<=0){
                cooltime = cooltimedefault;
                //clone mermi
                Instantiate(mermi1, barrel.position, barrel.rotation);
                //clone particle
                Instantiate(shoteffect, barrel.position, barrel.rotation);
                //animate
                arm.GetComponent<Animator>().SetTrigger("shot");
        }

    }
}
