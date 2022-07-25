using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{
    [SerializeField] private TMP_Text _leftPlayerScoreText;
    [SerializeField] private TMP_Text _rightPlayerScoreText;
    [SerializeField] private ScoreZone _leftScoreZone;
    [SerializeField] private ScoreZone _rightScoreZone;

    private int _leftScore;
    private int _rightScore;

    private void OnEnable()
    {
        _leftScoreZone.ScoreChanged += OnLeftScoreChanged;
        _rightScoreZone.ScoreChanged += OnRightScoreChanged;
    }

    private void OnDisable()
    {
        _leftScoreZone.ScoreChanged -= OnLeftScoreChanged;
        _rightScoreZone.ScoreChanged -= OnRightScoreChanged;
    }

    private void OnRightScoreChanged() => _rightScore = ScoreToText(_rightScore, _rightPlayerScoreText);


    private void OnLeftScoreChanged() => _leftScore = ScoreToText(_leftScore, _leftPlayerScoreText);


    private int ScoreToText(int score, TMP_Text text)
    {
        score++;
        text.text = score.ToString();
        return score;
    }

}
