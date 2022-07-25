using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        _rb.velocity = new Vector2(x * _speed, y * _speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out PlayerMovement platform))
            if (_rb.velocity.x < 8)
            {
                _speed++;
                _rb.velocity = new Vector2(_speed, _speed);
                Debug.Log(_rb.velocity.x);
            }
    }
}
