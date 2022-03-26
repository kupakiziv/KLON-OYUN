using UnityEngine;

public class Apples : MonoBehaviour
{
    
    public GameObject yarimelma;
    public GameObject elma1;
    public GameObject elma2;

   
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("apple"))
        {
            Instantiate(yarimelma, elma1.transform.position, elma1.transform.rotation);
            Destroy(GameObject.FindWithTag("apple"));
        }
        if (collision.collider.CompareTag("apple2"))
        {
            Instantiate(yarimelma, elma2.transform.position, elma2.transform.rotation);
            Destroy(GameObject.FindWithTag("apple2"));
        }

    }
}
