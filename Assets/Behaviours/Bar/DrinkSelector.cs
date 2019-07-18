using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinkSelector : MonoBehaviour
{

    public IntegerScriptable playerDrink;
    readonly List<double> positions =  new List<double> {0, -450, 0, 450 };
    Image image;
    

    void Start()
    {
        image = GetComponent<Image>();
    }

    void Update()
    {
        image.enabled = HaveDrinkSelected();
        UpdatePositionX((float)positions[playerDrink.value]);
       
    }

    void UpdatePositionX(float positionX)
    {
        transform.localPosition = new Vector3(positionX, transform.localPosition.y);
    }

    bool HaveDrinkSelected()
    {
        return playerDrink.value != 0;
    }
}
