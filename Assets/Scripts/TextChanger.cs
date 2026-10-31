using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private string _message1;
    [SerializeField] private string _message2;
    [SerializeField] private string _message3;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_message1, _duration));
        sequence.Append(_text.DOText(_message2, _duration).SetRelative());
        sequence.Append(_text.DOText(_message3, _duration, true, ScrambleMode.All));
        sequence.SetLoops(_repeats, _loopType);
    }
}
