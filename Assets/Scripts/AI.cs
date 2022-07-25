using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Spawner _spawner;

    private Rigidbody2D _ball;
    private Rigidbody2D _rb;

    private void Start() => _rb = GetComponent<Rigidbody2D>();

    private void OnEnable() => _spawner.Spawned += OnSpawned;

    private void OnDisable() => _spawner.Spawned -= OnSpawned;

    private void FixedUpdate()
    {
        if(_ball.velocity.x > 0)
        {
            if (_ball.position.y > transform.position.y)
                _rb.velocity = (Vector2.up * _speed);
            else if(_ball.position.y < transform.position.y)
                _rb.velocity = (Vector2.down * _speed);
        }
        
    }

    private void OnSpawned(GameObject ball) => _ball = ball.GetComponent<Rigidbody2D>();
}
