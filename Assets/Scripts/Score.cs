using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        scoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Points: " + scoreValue;
        if (scoreValue > PlayerPrefs.GetInt("wynik")) {
            PlayerPrefs.SetInt("wynik", scoreValue);
        }
        

    }
}
