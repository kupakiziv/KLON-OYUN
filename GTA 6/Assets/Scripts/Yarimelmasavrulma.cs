using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yarimelmasavrulma : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*0.01f);
    }
}
