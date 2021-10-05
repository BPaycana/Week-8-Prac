using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorekeeper : MonoBehaviour
{
    public static Scorekeeper instance;

    public Text scoreText1;

    public Text scoreText2;

    int score = 0;


    private void Awake()
        {
            instance = this;
        }

    // Start is called before the first frame update
    void Start()
    {
        scoreText1.text = "Player 1 Score: " + score.ToString();
        scoreText2.text = "Player 2 Score: " + score.ToString();
    }

    // Update is called once per frame

    public void AddPoint()
    {
        score += 1;
        scoreText1.text = "Player 1 Score: " + score.ToString();
    }

    public void AddPoint2()
    {
        score += 1;
        scoreText2.text = "Player 2 Score: " + score.ToString();
    }

    void Update()
    {
        
    }

}
