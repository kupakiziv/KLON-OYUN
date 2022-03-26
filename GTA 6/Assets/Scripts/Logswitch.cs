using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logswitch : MonoBehaviour
{
    
    public GameObject Shreddedlog;
    public GameObject Log;
    public int hitcount;
    public int knives;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (hitcount >= knives && GameObject.FindGameObjectWithTag("Nextbutton").activeInHierarchy == true)
        {
            Log.SetActive(false);
            Shreddedlog.SetActive(true);
        }
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("knife"))
        {

            hitcount += 1;

            
            Debug.Log("hit");
        }
    }
}
