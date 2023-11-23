using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerColliison : MonoBehaviour
{
    public GameBehaviour gb;
    private int score;
    public TextMeshProUGUI scoreText;
    void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Coin") {
            Destroy(collision.gameObject);
            score += 100;
            scoreText.text = "Score: " + score.ToString();
        }

        if(collision.gameObject.tag == "Wall") {
            print("Game Over!");
            gb.GameOver();
        }
    }
}
