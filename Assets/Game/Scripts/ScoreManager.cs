using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score
    {
        get;
        private set;
    }
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void SetScore(int score)
    {
        this.score = score;
    }

    public void AddScore(int value)
    {
        this.score += value;
    }

    public void AddScore(GameObject gameObject)
    {
        var scorable = gameObject.GetComponent<Scorable>();
        if (scorable != null)
        {
            Debug.Log(scorable.GetScore() + " added");
            score += scorable.GetScore();
        }
        else
        {
            Debug.Log(gameObject.name + " not scorable");
        }
    }
}
