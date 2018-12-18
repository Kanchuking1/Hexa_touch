using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGame : MonoBehaviour {
    public GameObject pauseButton;
    public GameObject resumeButton;
    
    public void Pause()
    {
        Time.timeScale = 0;
        pauseButton.SetActive(false);
        resumeButton.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        resumeButton.SetActive(false);
    }
}
