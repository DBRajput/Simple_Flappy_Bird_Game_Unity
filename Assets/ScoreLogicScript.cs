using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class ScoreLogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public AudioSource scoreAudio;

    [ContextMenu("Increase Score")]
    public void ScoreLogic(int addScore)
    {
        score = score + addScore;
        scoreText.text = score.ToString();
        scoreAudio.Play();
    }
}
