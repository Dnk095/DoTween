using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private RotateMode _rotateMode;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _repeats;

    private void Start()
    {
        transform.DORotate(_rotate, _duration, _rotateMode).SetLoops(_repeats, _loopType);
    }
}
