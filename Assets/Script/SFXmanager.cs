using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFXmanager : MonoBehaviour
{
    public AudioSource rightAnswer;
    public AudioSource wrongAnswer;
    public AudioSource winScreen;

    public void PlayRight()
    {
        rightAnswer.Play();
    }

    public void PlayWrong()
    {
        wrongAnswer.Play();
    }

    public void PlayWin()
    {
        winScreen.Play();
    }
}
