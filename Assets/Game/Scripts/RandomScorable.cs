
using System.Collections;
using UnityEngine;

public class RandomScorable : Scorable
{
    [System.Serializable]
    public class Score
    {
        public int min;
        public int max;
    }
    public Score scoreRange;

    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = Random.Range(scoreRange.min, scoreRange.max);
        StartCoroutine(RandomScore());
    }

    public IEnumerator RandomScore()
    {
        score = Random.Range(scoreRange.min, scoreRange.max + 1);
        Debug.Log("Random Score generated " + score);
        yield return new WaitForSeconds(1f);
        yield return RandomScore();
    }

    public override int GetScore()
    {
        return score;
    }
}
