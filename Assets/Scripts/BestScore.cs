using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScore : MonoBehaviour
{
    Text score;
    // Start is called before the first frame update
  
        
        // Start is called before the first frame update
        void Start()
    {
        score = GetComponent<Text>();
        score.text = PlayerPrefs.GetInt("wynik").ToString();
    }

}
