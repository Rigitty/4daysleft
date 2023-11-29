using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject armcontrollerobj;
    private Transform barrel;
    public Transform rightbarrel, leftbarrel;
    private RaycastHit2D hit;
    private float distance = 15f;
    private LineRenderer line;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }
    private void Update()
    {
        if (armcontrollerobj.GetComponent<armcontroller>().arm.GetComponent<Transform>().eulerAngles.z > 90 && armcontrollerobj.GetComponent<armcontroller>().arm.GetComponent<Transform>().eulerAngles.z < 270)
        {
            barrel = rightbarrel;
        }
        else
        {
            barrel = leftbarrel;
        }
        hit = Physics2D.Raycast(barrel.position, barrel.right,distance);

        line.SetPosition(0, barrel.position);
        line.SetPosition(1, hit.point);
    }
}
