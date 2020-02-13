using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameTitle : MonoBehaviour
{
    public RandomName randomName;
    // Start is called before the first frame update
    void Start()
    {
        enabled = false;
        StartCoroutine(UpdateTitle());
    }

    IEnumerator UpdateTitle()
    {
        GetComponent<TextMeshPro>().text = randomName.GetCurrentName() + " " + "Ninja";
        yield return new WaitForSeconds(5f);
    }
}
