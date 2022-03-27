using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    
    private Rigidbody rb;
    private Nextlevel nextlevel;
    public ParticleSystem kiymik;
    
    
    


    private KnifeSpawn knifeSpawn;
    private void Start()
    {
        
        knifeSpawn = GameObject.Find("Spawnpos").GetComponent<KnifeSpawn>();
        nextlevel = GameObject.Find("Levels").GetComponent<Nextlevel>();
        rb = GetComponent<Rigidbody>();
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("knife"))
        {
            
            nextlevel.isGameFailed = true;
            
            
        }
        else if ((collision.collider.CompareTag("kutuk")))
        {
            kiymik.Play();
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
            rb.transform.SetParent(collision.transform);
            if(knifeSpawn.remainedshots == 0)
            {

                nextlevel.isGameCompleted = true;
                
              

            }
            
        }


    }
}
