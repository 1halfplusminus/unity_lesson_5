using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomName : MonoBehaviour
{

    public string[] names = new string[] { "ECash", "eCash", "CagouCoin", "Kash", "eKash", "PacifiqueCoin" };
    // Start is called before the first frame update
    private string currentName;
    void Start()
    {
        StartCoroutine(UpdateName());
    }

    public string GetCurrentName()
    {
        return currentName;
    }
    IEnumerator UpdateName()
    {
        var randomIndex = Random.Range(0, names.Length);
        currentName = names[randomIndex];
        yield return new WaitForSeconds(5f);
        yield return UpdateName();
    }
}
