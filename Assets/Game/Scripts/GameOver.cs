using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private bool gameOver;
    public UnityEvent onGameOver;

    public void OnGameOver()
    {
        gameOver = true;
        onGameOver.Invoke();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(gameObject.scene.name);
    }
}
