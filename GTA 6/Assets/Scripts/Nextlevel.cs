using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextlevel : MonoBehaviour
{
    public GameObject[] levels = new GameObject[4];
    public int currentLevelNumber = 0;
    public static int Shotcount=0;

    public GameObject Nextlvlbutton;
    public GameObject RestartButton;
    public GameObject currentlevel;

    
    public bool isGameFailed;
    public bool isGameCompleted;

    void Start()
    {

        
        Nextlvlbutton.SetActive(false);
        
        currentlevel = Instantiate(levels[0]);
        
    
    }

    
    public void Throwaknife()
    {
        Shotcount++;
    }
    public void Nextlvl()
    {
     
        Destroy(currentlevel);
       
        currentLevelNumber++;
        currentlevel = Instantiate(levels[currentLevelNumber]);
        
        
        Shotcount = 0;
        isGameCompleted = false;
        Nextlvlbutton.SetActive(false);
       
    }
    public void Update()
    {
        if (isGameFailed)
        {
            RestartButton.SetActive(true);
      
            Nextlvlbutton.SetActive(false);
        }

        if (isGameCompleted)
        {
         
            
                
            Nextlvlbutton.SetActive(true);
                
            
          
            
            
        }
    }
    public void Restart()
    {
        
        Destroy(currentlevel);
        currentlevel=Instantiate(levels[0]);
        isGameFailed = false;
        RestartButton.SetActive(false);
        currentLevelNumber = 0;


    }

}
