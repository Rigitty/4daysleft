using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class badguy : MonoBehaviour
{
    [SerializeField] float gecikme = 0.5f;
    
    bool hasWin = false;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mermi" && hasWin == false)
        {
            hasWin = true;
            FindObjectOfType<armcontroller>().DisableControls();
           
            Invoke("ReloadScene", gecikme);
        }
    }
    void ReloadScene()
    {

        SceneManager.LoadScene(0);
    }
}
