using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIelements : MonoBehaviour
{
    public GameObject[] elements = new GameObject[7];
    public int shotCount = 0;
    public GameObject nextlvlmenu;
    public GameObject retrymenu;


    public  void Update()
    {
        if (shotCount == 7 && retrymenu.activeInHierarchy == false) 
        {
            {
                
                nextlvlmenu.SetActive(true);
                retrymenu.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    public void Destroy()
    {
        if (shotCount <= 6)
        {
            Destroy(elements[shotCount]);
            shotCount++;
            
        }
    }
}
