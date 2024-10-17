using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Text _text;
    [SerializeField] private LoopType _loopType;
    [SerializeField] private int _repeats;
    [SerializeField] private string _newText;

    private string _pasword = "21234412314sdfrfe";
    private Sequence _sequence;

    private void Awake()
    {
        _sequence = DOTween.Sequence();
    }
    private void Start()
    {
        _sequence.Append(_text.DOText(_newText, _duration));
        _sequence.Insert(_duration, _text.DOText(_newText, _duration).SetRelative());
        _sequence.Insert(_duration * 2, _text.DOText(_pasword, _duration, true, ScrambleMode.All));

        _sequence.SetLoops(_repeats, _loopType);
    }
}
