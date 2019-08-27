using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerMovement : MonoBehaviour
{
    public ListIntegerScriptable ordersPerTable;
    public ListFloatScriptable movementGridY;
    List<float> movementGridX = new List<float> { -4, 4};
    int tablePositionIndex;
    int drink = 0;

    void Start()
    {
        StartPosition();
        SetDrink();
        TakeATable();
    }

    void StartPosition()
    {
        int randPositionX = Random.Range(0, movementGridX.Count);
        int randPositionY = Random.Range(0, movementGridY.value.Count);

        transform.position = new Vector3(
            movementGridX[randPositionX],
            movementGridY.value[randPositionY]
        );

    }

    void TakeATable()
    {

        int index = 0;
        foreach(float positionY in movementGridY.value)
        {
            bool samePositionY = Mathf.Approximately(transform.position.y, positionY);
            if (samePositionY)
            {

                bool positionXIsLeft = Mathf.Approximately(transform.position.x, -4f);
                tablePositionIndex = positionXIsLeft ? index : index + 4;

            }
            index++;
        }
        ordersPerTable.value[tablePositionIndex] = drink;

    }

    void SetDrink()
    {
        switch(tag)
        {
            case "customer1":
                drink = 1;
                break;
            case "customer2":
                drink = 2;
                break;
            case "customer3":
                drink = 3;
                break;
        }
    }

}
