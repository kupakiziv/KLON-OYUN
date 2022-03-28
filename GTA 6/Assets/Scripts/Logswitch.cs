using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logswitch : MonoBehaviour
{
    
    public GameObject Shreddedlog;
    public GameObject Log;
    public int hitcount;
    public int knives;

    private GameObject nextButton;
    
    void Start()
    {
        if(nextButton == null)
        {
            nextButton = GameObject.Find("Levels").GetComponent<Nextlevel>().Nextlvlbutton;
        }
    }

    void Update()
    {
        if (hitcount >= knives && nextButton.activeInHierarchy == true)
        {
            Log.SetActive(false);
            Shreddedlog.SetActive(true);
        }
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("knife"))
        {
            hitcount++;
        }
    }
}
