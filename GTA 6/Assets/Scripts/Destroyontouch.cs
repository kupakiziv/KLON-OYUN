using UnityEngine;

public class Destroyontouch : MonoBehaviour
{
    
    
    public void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
