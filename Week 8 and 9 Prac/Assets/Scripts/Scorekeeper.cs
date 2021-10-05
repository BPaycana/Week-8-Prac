using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorekeeper : MonoBehaviour
{
    public static Scorekeeper instance;

    public Text scoreText1;

    public Text scoreText2;

    int scoreP1 = 0;
    int scoreP2 = 0;


    private void Awake()
        {
            instance = this;
        }

    // Start is called before the first frame update
    void Start()
    {
        scoreText1.text = "Player 1 Score: " + scoreP1.ToString();
        scoreText2.text = "Player 2 Score: " + scoreP2.ToString();
    }

    // Update is called once per frame

    public void AddPoint()
    {
        scoreP1 += 1;
        scoreText1.text = "Player 1 Score: " + scoreP1.ToString();
    }

    public void AddPoint2()
    {
        scoreP2 += 1;
        scoreText2.text = "Player 2 Score: " + scoreP2.ToString();
    }

    void Update()
    {
        
    }

}
