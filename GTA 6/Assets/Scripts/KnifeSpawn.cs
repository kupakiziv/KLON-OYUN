
using UnityEngine;



public class KnifeSpawn : MonoBehaviour
{
    
    public GameObject Knife;
    private GameObject spawnedKnife;
    public Transform spawnpoint;
    public int remainedshots;

    public float throwforce;

    private Nextlevel nextlevel;

    public void Start()
    {
        nextlevel = GameObject.Find("Levels").GetComponent<Nextlevel>();
        spawnpoint = this.gameObject.transform;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !nextlevel.isGameFailed)
        {
            SpawnKnife();
        }
    }
    

    public void SpawnKnife()
    {
        if (remainedshots > 0)
        {
            spawnedKnife = Instantiate(Knife, spawnpoint.transform.position, spawnpoint.transform.rotation * Quaternion.Euler(-90, 0, 0f));

            spawnedKnife.GetComponent<Rigidbody>().AddForce(throwforce * Vector3.up * 3);

            AudioManager.instance.PlayAudio(AudioManager.AudioCallers.KnifeThrow);

            remainedshots--;


        }
    }

}
   





