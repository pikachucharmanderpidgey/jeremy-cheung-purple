using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text score_Text scoreText;
    private int score;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject);
    }
}
