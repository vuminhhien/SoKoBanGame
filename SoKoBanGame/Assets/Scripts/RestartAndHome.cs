using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartAndHome : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // quay về lại nơi bắt đầu của màn chơi đó
        Time.timeScale = 1;
    }
    public void Home()
    {
        
    }
}
