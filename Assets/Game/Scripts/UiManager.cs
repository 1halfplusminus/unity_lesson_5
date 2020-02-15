using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject gameScreen;
    public GameObject gameOverScreen;
    public GameObject startScreen;
    // Start is called before the first frame update
    void Start()
    {
        gameScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        startScreen.SetActive(true);
    }
    public void GameStart()
    {
        gameScreen.SetActive(true);
        gameOverScreen.SetActive(false);
        startScreen.SetActive(false);
    }
    public void DisplayGameOverScreen()
    {
        StartCoroutine(DisplayGameOverCorroutine());
    }

    private IEnumerator DisplayGameOverCorroutine()
    {
        yield return new WaitForSeconds(0.5f);
        gameOverScreen.SetActive(true);
        startScreen.SetActive(false);
        gameScreen.SetActive(false);
    }
}
