using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreRender : MonoBehaviour
{
    public IntegerScriptable score;
    TextMeshProUGUI textMeshPro;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        score.value = 0;
    }

    void Update()
    {
        textMeshPro.text = score.value.ToString();
    }
}
