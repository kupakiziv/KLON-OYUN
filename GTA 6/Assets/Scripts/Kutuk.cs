using UnityEngine;
using DG.Tweening;

public class Kutuk : MonoBehaviour
{
   

    public Nextlevel nextlevelScript;

    #region Changes
    private Ease ease;

    private float speed;

    #endregion

    void Start()
    {
        nextlevelScript = GameObject.Find("Levels").GetComponent<Nextlevel>();
        SpeedAndEaseSetup();
        RotateWoodenLog();
    }

    private void RotateWoodenLog()
    {
        transform.DORotate(new Vector3(0, 0, 360), speed * 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(ease);

    }

    private void SpeedAndEaseSetup()
    {
        switch (nextlevelScript.currentLevelNumber)
        {
            case 0:
                ease = Ease.Linear;
                speed = 1f;
                break;
            case 1:
                ease = Ease.Linear;
                speed = 0.8f;
                break;
            case 2:
                ease = Ease.InBack;
                speed = 1.5f;
                break;
            case 3:
                ease = Ease.InOutFlash;
                speed = 2f;
                break;
            case 4:
                ease = Ease.InOutBack;
                speed = 2f;
                break;
        }
    }
}
