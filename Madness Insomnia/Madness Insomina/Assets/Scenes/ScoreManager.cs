using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManerger : MonoBehaviour
{
    public GameObject WinText;
    public TMP_Text scoretext;
    public int score = 0;
    public AudioSource SoundPickUp;

    public void AddScore(int _amount)
    { 
        score += _amount;   
        scoretext.text = "Hearts:     " + score;
        SoundPickUp.Play();

        if (score > 33)
        {
            WinText.SetActive(true);

        }

    }
}