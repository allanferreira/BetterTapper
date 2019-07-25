using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrderFeedbackRender : MonoBehaviour
{

    public StringScriptable orderFeedback;
    TextMeshProUGUI textMeshPro;
    Color textColor;

    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        orderFeedback.value = "";
        textColor = Color.white;
    }

    void Update()
    {        
        textMeshPro.text = orderFeedback.value;
        textMeshPro.color = textColor;
    }

    public void Message(string message, Color color)
    {
        orderFeedback.value = message;
        textColor = color;
    }

    public void Clear()
    {
        orderFeedback.value = "";
    }
}
