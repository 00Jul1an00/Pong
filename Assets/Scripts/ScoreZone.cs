using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreZone : MonoBehaviour
{
    public event UnityAction ScoreChanged;

    private void OnCollisionEnter2D(Collision2D collision) => ScoreChanged?.Invoke();
}
