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
    public GameObject armcontrollerobj;
    void Update()
    {
        if (armcontrollerobj.GetComponent<armcontroller>().arm.GetComponent<Transform>().eulerAngles.z > 90 && armcontrollerobj.GetComponent<armcontroller>().arm.GetComponent<Transform>().eulerAngles.z < 270)
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
        if ((Input.GetKeyDown(KeyCode.Mouse0)|| Input.GetKeyDown(KeyCode.Space)) && cooltime<=0){
            Camera.main.GetComponent<AudioSource>().PlayOneShot(shotsound,0.05f);
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
