using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkSelector : MonoBehaviour
{

    public IntegerScriptable playerDrink;
    readonly List<double> positions =  new List<double> {0, -4.5, 0, 4.5 };
    SpriteRenderer spriteRenderer;
    

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {

        spriteRenderer.enabled = HaveDrinkSelected();
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
