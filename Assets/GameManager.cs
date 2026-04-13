using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public GameManager gameManager;
    public TextMeshProUGUI player1ScoreText;
    public TextMeshProUGUI player2ScoreText;
    private int player1Score;
    private int player2Score;
    
    public void Player1Scores()
    {
            player1Score++;
            player1ScoreText.text = player1Score.ToString();
            this.ball.ResetPosition();
    }

    public void Player2Scores()
{
    Debug.Log("Ball ref: " + ball);
    Debug.Log("Text ref: " + player2ScoreText);

    player2Score++;

    player2ScoreText.text = player2Score.ToString();

    this.ball.ResetPosition();
}

    private void ResetBall()
    {
        
    }
}
