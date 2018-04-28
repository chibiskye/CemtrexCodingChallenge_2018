using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public int score;

    private void Start()
    {
        score = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);

        Destroy(other.gameObject);
        score += 10;

        scoreText.text = "Score: " + score;
    }

}
