using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IScorable
{
    int GetScore();
}

public class Scorable : MonoBehaviour, IScorable
{
    public virtual int GetScore()
    {
        throw new System.NotImplementedException();
    }
}