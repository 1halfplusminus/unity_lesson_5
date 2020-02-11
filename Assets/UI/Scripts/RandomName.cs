using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomName : MonoBehaviour
{

    public string[] names = new string[] { "ECash", "eCash", "CagouCoin", "Kash", "eKash", "PacifiqueCoin" };
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(UpdateName());
    }

    IEnumerator UpdateName()
    {
        yield return new WaitForSeconds(5f);
        var randomIndex = Random.Range(0, names.Length);
        GetComponent<TextMeshProUGUI>().text = names[randomIndex] + " : ";
        yield return UpdateName();
    }
}
