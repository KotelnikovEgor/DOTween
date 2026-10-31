using UnityEngine;
using DG.Tweening;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _yPosition;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMoveY(_yPosition, _duration).SetEase(Ease.Linear).SetLoops(_repeats, _loopType);
    }
}
