using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class silah : MonoBehaviour
{
   
    public GameObject mermi1;
    private Transform barrel;
    public Transform rightbarrel, leftbarrel;
    private float time1;
    public GameObject shoteffect;
    private GameObject arm;
    public GameObject armleft, armright;
    public float cooltimedefault;
    private float cooltime;
    public AudioClip shotsound;
    
    void Update()
    {
        if (GetComponent<armcontroller>().arm.GetComponent<Transform>().eulerAngles.z > 90 && GetComponent<armcontroller>().arm.GetComponent<Transform>().eulerAngles.z < 270)
        {
            barrel = rightbarrel;
            arm = armright;
        }
        else
        {
            barrel = leftbarrel;
            arm = armleft;
        }

        //timer
        time1 = time1 + Time.deltaTime;
        if (cooltime > 0)
        {
           cooltime = cooltime - Time.deltaTime;
        }
        print(barrel.transform.rotation.eulerAngles);
        if (Input.GetKeyDown("space") && cooltime<=0){
            Camera.main.GetComponent<AudioSource>().PlayOneShot(shotsound);
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
