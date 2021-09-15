using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{
    public GameObject pauseUI;

    private void Start()
    {
        pauseUI.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.GetComponent<PlayerController>();
        if(player != null){
            pauseUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
