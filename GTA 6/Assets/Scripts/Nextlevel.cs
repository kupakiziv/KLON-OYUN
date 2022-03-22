using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextlevel : MonoBehaviour
{
    public GameObject[] levels = new GameObject[4];
    public int c = 0;
    public static int Shotcount=0;
    public GameObject Spawnbutton;
    public GameObject Nextlvlbutton;
    public GameObject Restarbutton;
    public GameObject currentlevel;


    void Start()
    {
        Spawnbutton.SetActive(true);
        Nextlvlbutton.SetActive(false);
        
        currentlevel = Instantiate(levels[0]);
        //levels[0].SetActive(true);
    }

    // Update is called once per frame
    public void Throwaknife()
    {
        Shotcount++;
    }
    public void Nextlvl()
    {
        c++;
        Debug.Log(c);
        for (int x=0; x < levels.Length; x++)
        {
            if (c == x)
            {
                
                //levels[c].SetActive(true);
                Destroy(currentlevel);

                currentlevel = Instantiate(levels[c]);
                
                //levels[c - 1].SetActive(false);
                Shotcount = 0;
                Nextlvlbutton.SetActive(false);
                Spawnbutton.SetActive(true);

            }
        }
    }
    public void Update()
    {
        if (Time.timeScale == 0)
        {
            Restarbutton.SetActive(true);
            Spawnbutton.SetActive(false);
             Nextlvlbutton.SetActive(false);
}
        if (Shotcount == 7)
        {
            Spawnbutton.SetActive(false);
            Nextlvlbutton.SetActive(true);
        }
    }
    public void Restart()
    {
        Time.timeScale = 1;
        Restarbutton.SetActive(false);
        Spawnbutton.SetActive(true);
        
        //levels[0].SetActive(true);
        Destroy(currentlevel);
        currentlevel=Instantiate(levels[0]);
        
        
    }

}
