using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class deneme : MonoBehaviour
{
    public Transform level1;
    public Transform level2;
    public Transform level3;
    public Transform level4;


    void Start()
    {
        level1.DORotate(new Vector3(0,0,360),1*2f,RotateMode.FastBeyond360).SetLoops(-1,LoopType.Restart).SetEase(Ease.Linear);
        level2.DORotate(new Vector3(0, 0, 360), 1 * 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
        level3.transform.DORotate(new Vector3(0, 0, 360), 1.5f * 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutBack);
        level4.transform.DORotate(new Vector3(0, 0, 180), 2f * 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutBounce);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
