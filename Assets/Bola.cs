using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {
    public float speed = 10.0f;
    public Placar placar;

    void Start() {
        ResetarBolinha();
    }

    void ResetarBolinha() {
        float direction = Random.Range(0, 2) == 0 ? -1 : 1;

        Vector2 position = new Vector2(direction * (-5), 0);
        transform.position = position;

        GetComponent<Rigidbody2D>().velocity = new Vector2(direction * speed, 0);
    }

    float hitFactor(Vector2 bolaPos, Vector2 jogPos, float tam) {
        return (bolaPos.y - jogPos.y) / tam;
    }

    void OnCollisionEnter2D(Collision2D colisao) {
        if (colisao.gameObject.name == "raquete_esquerda") {
            float y = hitFactor(transform.position, colisao.transform.position, colisao.collider.bounds.size.y);

            Vector2 dir = new Vector2(1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (colisao.gameObject.name == "raquete_direita") {
            float y = hitFactor(transform.position, colisao.transform.position, colisao.collider.bounds.size.y);

            Vector2 dir = new Vector2(-1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }

        if (colisao.gameObject.name == "parede_esquerda") {
            placar.Jogador2MarcouPonto();
            ResetarBolinha();
        }

        if (colisao.gameObject.name == "parede_direita") {
            placar.Jogador1MarcouPonto();
            ResetarBolinha();
        }
    }
}
