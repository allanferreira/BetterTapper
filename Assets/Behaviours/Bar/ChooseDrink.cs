using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseDrink : MonoBehaviour
{
    public IntegerScriptable playerDrink;
    public int drinkNumber;

    void Start()
    {
        playerDrink.value = 0;    
    }

    void Update()
    {
        
    }

    void OnMouseDown()
    {
        print(drinkNumber);
        playerDrink.value = drinkNumber;
    }
}
