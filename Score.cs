using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int scoreValue = 0;

    public static int highscore;

    Text score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        highscore = PlayerPrefs.GetInt("highscore", highscore);
        text.score = highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (score > highscore)
        {
            highscore = score;
            score.text = " " + scoreValue;

            PlayerPrefs.SetInt("highscore", highscore);
        }
    }

}
