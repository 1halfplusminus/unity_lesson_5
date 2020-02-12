using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject gameScreen;
    public GameObject gameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
        gameScreen.SetActive(true);
        gameOverScreen.SetActive(false);
    }

    public void DisplayGameOverScreen()
    {
        gameOverScreen.SetActive(true);
    }
}
