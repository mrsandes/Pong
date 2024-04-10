using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public Text player1ScoreText;
    public Text player2ScoreText;

    private int player1Score = 0;
    private int player2Score = 0;

    void Start() {
        UpdateScoreText();
    }

    public void AddPlayer1Score(int points) {
        player1Score += points; 
        UpdateScoreText();
    }

    public void AddPlayer2Score(int points) {
        player2Score += points;
        UpdateScoreText();
    }

    void OnCollisionEnter2D(Collision2D colisao) {
        if (colisao.gameObject.name == "parede_esquerda") {
            pontosPlayer2++;
        }

        if (colisao.gameObject.name == "parede_direita") {
            pontosPlayer1++;
        }
    }

    void UpdateScoreText() {
        player1ScoreText.text = player1Score.ToString();
        player2ScoreText.text = player2Score.ToString();
    }
}