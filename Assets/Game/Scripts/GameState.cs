using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour
{
    private bool gameOver;
    public UnityEvent onGameOver;
    public UnityEvent onGameStart;
    public void OnGameOver()
    {
        gameOver = true;
        onGameOver.Invoke();
    }
    public void OnGameStart()
    {
        gameOver = false;
        onGameStart.Invoke();
    }
    public void RestartGame()
    {
        gameOver = false;
        SceneManager.LoadScene(gameObject.scene.name);
    }
}
