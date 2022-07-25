using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Vector2 direction;
    private Rigidbody2D _rb;

    private void Start() => _rb = GetComponent<Rigidbody2D>();

    private void FixedUpdate()
    {
        direction = Vector2.zero;

        if(Input.GetKey(KeyCode.W))
            direction = Vector2.up;

        if(Input.GetKey(KeyCode.S))
            direction = Vector2.down;

        _rb.velocity = direction * _speed;
    }
}
