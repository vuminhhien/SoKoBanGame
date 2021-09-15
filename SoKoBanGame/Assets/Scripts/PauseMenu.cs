using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject buttonPause;
    // Start is called before the first frame update
    void Start()
    {
        pauseUI.SetActive(false);
        buttonPause.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Pause(){
        pauseUI.SetActive(true);
        Time.timeScale = 0;
        buttonPause.SetActive(false);
    }

    public void Play(){
        pauseUI.SetActive(false);
        Time.timeScale = 1;
        buttonPause.SetActive(true);
    }
}
