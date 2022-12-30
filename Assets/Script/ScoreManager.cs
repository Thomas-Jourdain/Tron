using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{

    public GameObject player;
    public static ScoreManager instance;
    public Text scoreText;
    int score= 0;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = player.name.ToString() + " : " + score.ToString() + " POINTS";
    }

    public void addPoint()
    {
        score += 1;
        scoreText.text = player.name.ToString() + " : " + score.ToString() + " POINTS";
    }
}
