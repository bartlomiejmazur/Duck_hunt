using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public Text gainedPointsText;
    private GameObject GameManager;



    void Start()
    {
        gainedPointsText.text = Score.scoreValue.ToString();
    }
    public void RestartButton()
    {
        System.Threading.Thread.Sleep(500);
        SceneManager.LoadScene(0);
    }
    public void MenuExitButton()
    {
        System.Threading.Thread.Sleep(500);
        Application.Quit();
    }
    

    

    
}
