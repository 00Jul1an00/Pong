using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private BallDestroyer _ballDestroyer;

    private Vector2 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void OnEnable()
    {
        _ballDestroyer.BallDestroy += OnBallDestroy;
    }   

    private void OnDisable()
    {
       _ballDestroyer.BallDestroy -= OnBallDestroy;
    }

    private void ResetPosition() => transform.position = _startPosition;

    private void OnBallDestroy() => ResetPosition();
}
