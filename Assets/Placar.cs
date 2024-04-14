using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Placar : MonoBehaviour {
    public TextMeshProUGUI textoPlacar;
    private int pontuacaoJogador1 = 0;
    private int pontuacaoJogador2 = 0;

    void Start() {
        AtualizarPlacar();
    }

    public void Jogador1MarcouPonto() {
        pontuacaoJogador1++;
        AtualizarPlacar();
    }

    public void Jogador2MarcouPonto() {
        pontuacaoJogador2++;
        AtualizarPlacar();
    }

    void AtualizarPlacar() {
        textoPlacar.text = pontuacaoJogador1 + " - " + pontuacaoJogador2;
    }
}
