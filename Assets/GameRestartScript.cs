using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestartScript : MonoBehaviour
{
    public GameObject GameOverScreen;
    public AudioSource gameOverAudio;
    public bool oneTime = true;
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void RestartGameScreen()
    {

        GameOverScreen.SetActive(true);
        if (oneTime == true)
        {
            gameOverAudio.Play();
            oneTime = false;
        }
    }


}
