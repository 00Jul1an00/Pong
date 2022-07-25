using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private BallDestroyer _BallDestroyer;

    public event UnityAction<GameObject> Spawned;

    private void Awake() => Spawn();

    private void OnEnable()
    {
        _BallDestroyer.BallDestroy += OnBallDestroyer;
    }

    private void OnDisable()
    {
        _BallDestroyer.BallDestroy -= OnBallDestroyer;
    }

    private void Spawn()
    {
        GameObject ball = Instantiate(_prefab, transform.position, Quaternion.identity, transform);
        Spawned?.Invoke(ball);
    }

        private void OnBallDestroyer() => Spawn();
}
