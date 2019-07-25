using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseDrink : MonoBehaviour
{
    public IntegerScriptable playerDrink;
    
    public int drinkNumber;

    void Start()
    {
        playerDrink.value = 0;
    
    }

    void ClickHandler()
    {
        playerDrink.value = drinkNumber;
    }
}
