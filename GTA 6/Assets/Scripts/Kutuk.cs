using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Kutuk : MonoBehaviour
{
    public RETRY Retry;
    //public Transform level2;
    //public Transform level3;
    //public Transform level4;
    
    #region Changes
    private Ease ease;

    private float speed;

	#endregion

    void Start()
    {
        SpeedSetup();
        EaseSetup();

        transform.DORotate(new Vector3(0, 0, 360), speed * 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(ease);
        //level2.DORotate(new Vector3(0, 0, 360), 1 * 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        //level3.transform.DORotate(new Vector3(0, 0, 360), 1.5f * 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutBack);
        //level4.transform.DORotate(new Vector3(0, 0, 180), 2f * 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutBounce);
    }

    private void SpeedSetup()
    {
        switch (Retry.a)
        {
            case 0:
                speed = 1f;
                break;
            case 1:
                speed = 1f;
                break;
            case 2:
                speed = 1.5f;
                break;
            case 3:
                speed = 2f;
                break;
        }
    }
    private void EaseSetup()
    {
        switch (Retry.a)
        {
            case 0:
                ease = Ease.Linear;
                break;
            case 1:
                ease = Ease.Linear;
                break;
            case 2:
                ease = Ease.InOutBack;
                break;
            case 3:
                ease = Ease.InOutBounce;
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
