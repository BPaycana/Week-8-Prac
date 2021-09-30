using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorekeeper : MonoBehaviour
{
    public static Scorekeeper instance;

    public Text scoreText;

    int score = 0;


    private void Awake()
        {
            instance = this;
        }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }

    void Update()
    {

    }

}
