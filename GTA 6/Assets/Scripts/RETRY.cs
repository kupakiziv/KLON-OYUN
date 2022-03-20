using UnityEngine.SceneManagement;
using UnityEngine;

public class RETRY : MonoBehaviour
{
    public GameObject Gameovermenu;
    public GameObject nextlvlmenu;
    public static int a=0;
    public void Start()
    {
        
    }
    public void Update()
    {
        if (Time.timeScale == 0 )

        {
            Gameovermenu.SetActive(true);
            nextlvlmenu.SetActive(false);
        }
    }
    // Update is called once per frame
    public void retry()
    {
        a = 0;
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        Gameovermenu.SetActive(false);
        
    }
    public void Nextlevel()
    {
        a++;
        Debug.Log(a);
        switch (a)
        {
            case 1:
                SceneManager.LoadScene(a);
                break;
            case 2:
                SceneManager.LoadScene(2);
                break;
            case 3:
                SceneManager.LoadScene(3);
                break;
        }
        
    }
}
