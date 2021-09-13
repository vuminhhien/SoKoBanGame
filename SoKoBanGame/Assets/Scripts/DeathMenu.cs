using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        pauseUI.SetActive(false);
    }
   private void OnCollisionEnter2D(Collision2D other)
   {
       if(player != null){
           pauseUI.SetActive(true);
           Time.timeScale = 0;
       }
   }
}
