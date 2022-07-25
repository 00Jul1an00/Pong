using UnityEngine;
using UnityEngine.Events;

public class BallDestroyer : MonoBehaviour
{
    public event UnityAction BallDestroy;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.TryGetComponent(out Ball ball))
        {
            Destroy(ball.gameObject);
            BallDestroy?.Invoke();
        }
    }
}
