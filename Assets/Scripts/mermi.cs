using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mermi : MonoBehaviour
{
    public Rigidbody2D rb2D;
    [SerializeField] float hiz=10;
     public GameObject mermi1;
     public Transform konum;
void Update(){
    bool ates= Input.GetKeyDown("space");
        
        if (ates){
        Instantiate(mermi1,konum.position,konum.rotation);
        rb2D.velocity=new Vector3(hiz * Time.deltaTime,0,0);


        }
        else{
            ates=false;
        }
        
}
}
