using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource gameOverSound;
    public AudioSource goodClick;

    public AudioSource insertCoin;

    public AudioSource gameOverLoop;

    public AudioSource startLoop;

    public AudioSource gameLoop;

    void Start()
    {
        startLoop.Play();
    }
    public void PlayStartLoop()
    {
        gameLoop.Stop();
        gameOverLoop.Stop();
        startLoop.Play();
    }
    public void PlayInsertCoin()
    {
        startLoop.Stop();
        gameOverLoop.Stop();
        gameLoop.PlayDelayed(0.3f);
    }
    public void PlayGameOver()
    {
        startLoop.Stop();
        gameLoop.Stop();
        gameOverSound.Play();
        gameOverLoop.PlayDelayed(0.5f);
    }

    public void GoodClick()
    {
        goodClick.Play();
    }
}
