using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armcontroller : MonoBehaviour
{
    public GameObject arm;
    private int privatespeed=100;
    public int publicspeed;
    private void Update()
    {
        if ((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.A)))
        {
            arm.transform.Rotate(new Vector3(0,0,1)* publicspeed*privatespeed*Time.deltaTime);
        }
        if ((Input.GetKey(KeyCode.S)) || (Input.GetKey(KeyCode.D)))
        {
            arm.transform.Rotate(new Vector3(0, 0, -1) * publicspeed * privatespeed * Time.deltaTime);
        }
    }
}
