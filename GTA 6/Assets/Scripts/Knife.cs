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
        if (collision.gameObject.tag == "knife" && nextlevel.isGameFailed == false)
        {
            rb.isKinematic = false; 
            rb.transform.position = new Vector3(rb.transform.position.x, rb.transform.position.y, rb.transform.position.z - 1);
            rb.velocity = new Vector3(rb.velocity.x, -10, -10);
            rb.useGravity = true;
            Destroy(gameObject, 2f);
            

            nextlevel.isGameFailed = true;
            nextlevel.isGameCompleted = false;
            AudioManager.instance.PlayAudio(AudioManager.AudioCallers.KnifeHitKnife);
            //AudioManager.instance.PlayAudio(AudioManager.AudioCallers.GameFailed);
        }
        else if (collision.gameObject.tag == "kutuk" && nextlevel.isGameFailed == false)
        {
            kiymik.Play();
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
            rb.transform.SetParent(collision.transform);
            AudioManager.instance.PlayAudio(AudioManager.AudioCallers.KnifeHitWood);
            Destroy(GetComponent<Knife>(), 0.05f);


            if (knifeSpawn.remainedshots == 0 && !nextlevel.isGameFailed)
            {
                nextlevel.isGameCompleted = true;
                //AudioManager.instance.PlayAudio(AudioManager.AudioCallers.LevelPassed);
            }
        }


    }

}
