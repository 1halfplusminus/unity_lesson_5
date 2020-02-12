using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreLabel : MonoBehaviour
{
    private TextMeshProUGUI textMesh;
    public ScoreManager scoreManager;
    public RandomName randomName;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.text = randomName.GetCurrentName() + " : " + scoreManager.score;
    }
}
