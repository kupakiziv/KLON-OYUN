using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextlevel : MonoBehaviour
{
    public GameObject[] levels = new GameObject[4];
    public int currentLevelNumber = 0;
    public static int Shotcount=0;
    //public GameObject Spawnbutton;
    public GameObject Nextlvlbutton;
    public GameObject RestartButton;
    public GameObject currentlevel;

    [SerializeField]
    private KnifeSpawn knifeSpawn;

    private bool isGamePlaying;
    public bool isGameFailed;
    public bool isGameCompleted;

    void Start()
    {
        //Spawnbutton.SetActive(true);
        Nextlvlbutton.SetActive(false);
        
        currentlevel = Instantiate(levels[0]);
        knifeSpawn = currentlevel.GetComponentInChildren<KnifeSpawn>();
        //levels[0].SetActive(true);
    }

    // Update is called once per frame
    public void Throwaknife()
    {
        Shotcount++;
    }
    public void Nextlvl()
    {
        //levels[c].SetActive(true);
        Destroy(currentlevel);
        knifeSpawn = null;
        currentLevelNumber++;
        currentlevel = Instantiate(levels[currentLevelNumber]);
        knifeSpawn = currentlevel.GetComponentInChildren<KnifeSpawn>();
        //levels[c - 1].SetActive(false);
        Shotcount = 0;
        isGameCompleted = false;
        Nextlvlbutton.SetActive(false);
        //Spawnbutton.SetActive(true);
    }
    public void Update()
    {
        if (isGameFailed)
        {
            RestartButton.SetActive(true);
            //Spawnbutton.SetActive(false);
            Nextlvlbutton.SetActive(false);
        }

        if (isGameCompleted)
        {
            //Spawnbutton.SetActive(false);
            Nextlvlbutton.SetActive(true);
            isGamePlaying = false;
        }
    }
    public void Restart()
    {
        //Spawnbutton.SetActive(true);
        
        //levels[0].SetActive(true);
        Destroy(currentlevel);
        currentlevel=Instantiate(levels[0]);
        isGameFailed = false;
        RestartButton.SetActive(false);
        currentLevelNumber = 0;


    }

}
