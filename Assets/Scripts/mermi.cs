using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{
  
    public float bulletspeed;
    private float time1;
    public float lifetime;
    Vector3 lastVelocity;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * bulletspeed);
        
       
    }





    private void Update()
    {


        //timer
        time1 = time1 +Time.deltaTime;

        //velocity
       
        lastVelocity = rb.velocity;
       

        //destroy
        if (time1 > lifetime)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        var speed= lastVelocity.magnitude;
        var direction=Vector3.Reflect(lastVelocity.normalized, coll.contacts [0].normal);

        rb.velocity = direction * Mathf.Max(speed,0f);
    }
   
}

