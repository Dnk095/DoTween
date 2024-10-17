using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _repeats;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        _spriteRenderer.DOColor(_color, _duration).SetLoops(_repeats, _loopType);
    }
}
