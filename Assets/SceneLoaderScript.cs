using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoaderScript : MonoBehaviour
{
    public void GameExit()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }
}
