using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{
    public int bulletspeed;
    private float time1;
    public float lifetime;
    private void Update()
    {
        //timer
        time1 = time1 +Time.deltaTime;

        //velocity
        transform.Translate(Vector3.right* bulletspeed*Time.deltaTime);

        //destroy
        if (time1 > lifetime)
        {
            Destroy(gameObject);
        }
    }
}
