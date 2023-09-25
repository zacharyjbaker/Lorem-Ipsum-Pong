using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public TMP_Text playerScoreText;
    public TMP_Text computerScoreText;
    public TMP_Text word;
    public AudioClip YouLose;
    public AudioClip YouWin;


    private int _playerScore;

    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        //Debug.Log(_playerScore);
        if (_playerScore == 5)
        {
            GameOver(1);
        }
        else
        {
            ResetRound();
        }
    }

    public void ComputerScores()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        //Debug.Log(_computerScore);
        if (_computerScore == 5)
        {
            GameOver(0);
        }
        else
        {
            ResetRound();
        }
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void GameOver(int result)
    {
        if (result == 1)
        {
            GetComponent<AudioSource>().PlayOneShot(YouWin);
            this.word.text = "YOU WIN!\nPRESS Q TO RESTART";
        }
        else
        {
            GetComponent<AudioSource>().PlayOneShot(YouLose);
            this.word.text = "YOU DIE!\nPRESS Q TO RESTART";
        }
        Time.timeScale = 0.0f;
    }


}
