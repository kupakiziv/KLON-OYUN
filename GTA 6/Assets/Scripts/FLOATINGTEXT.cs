using DG.Tweening;
using UnityEngine;

public class FloatingText : MonoBehaviour
{

    void Start()
    {
        transform.DOMove(new Vector3(0, 0, 10), 3).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
        transform.DORotate(new Vector3(0, 90, 0), 3).SetEase(Ease.InOutSine).SetLoops(-1, LoopType.Yoyo);
    }


}
