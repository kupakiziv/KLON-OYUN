
using UnityEngine;
using UnityEngine.SceneManagement;


public class KnifeSpawn : MonoBehaviour
{
    public GameObject menu;
    public Transform spawnpoint;
    public  static int remainedshots = 7;
    public static int shots = 0;


    public float throwforce=10f;
    




    public Rigidbody rb;
    //public float throwforce = 90;

    public void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        if (SceneManager.sceneCount == 1)
        {
            remainedshots += 7;
        }

    }
    


    void FixedUpdate()
    {
        
        rb.AddForce(Vector3.up *throwforce*90);
       
}
    

    public void Knifespawn()
    {
        if (remainedshots > 0)
        {
            Instantiate(rb, spawnpoint.transform.position, spawnpoint.transform.rotation*Quaternion.Euler(-90f, 0, 0f));
            remainedshots-=1;
            shots++;
        }
    }
    
    public void OnCollisionEnter(Collision collision)
    {
        
        if (collision.collider.CompareTag("box"))
        {

            menu.SetActive(true);
            
            Time.timeScale = 0f;
           

            Debug.Log(collision.gameObject.name);
        }
        else if ((collision.collider.CompareTag("kutuk"))) { 
            rb.velocity = Vector3.zero;
            rb.isKinematic = true;
            rb.transform.SetParent(collision.transform);
            //Debug.Log(collision.gameObject.name);
        }
        

    }

    public void shotrefrsh()
    {
        remainedshots += shots;
    }


}
   





