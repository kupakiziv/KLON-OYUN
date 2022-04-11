using UnityEngine;

public class UIknives : MonoBehaviour
{
    public GameObject[] knives = new GameObject[7];
    public int counter = 0;
    public Nextlevel next;
    void Start()
    {
        next = FindObjectOfType<Nextlevel>();
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&&counter<knives.Length)
        {
            if(next.isGameFailed == false)
            {
                Destroy(knives[counter]);
                counter++;
            }
            
        }
    }
    
}
