using UnityEngine;
using DG.Tweening;

public class Colorizer : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        _material.color = Color.gray;
        _material.DOColor(_color, _duration).SetEase(Ease.Linear).SetLoops(_repeats, _loopType);
    }
}
