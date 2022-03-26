using UnityEngine;

public class Yarimelmadestroy : MonoBehaviour
{

    void Update()
    {
        if (gameObject.transform.position.y < -30)
        {
            Destroy(gameObject);
        }
    }
}
