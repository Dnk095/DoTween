using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private Vector3 _position;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(_repeats, _loopType);
    }
}