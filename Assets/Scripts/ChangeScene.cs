using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void Btn_click_change_scene(string SceneName)
    {
        System.Threading.Thread.Sleep(500);
        SceneManager.LoadScene(SceneName);   
    }
}
