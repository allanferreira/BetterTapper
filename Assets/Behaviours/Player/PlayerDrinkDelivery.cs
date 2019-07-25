using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDrinkDelivery : MonoBehaviour
{
    public IntegerScriptable playerGridPosition;
    public IntegerScriptable playerDrink;
    public GameObject orderFeedbackUI;
    OrderFeedbackRender orderFeedbackRender;

    public ListIntegerScriptable ordersPerTable;
    int currentOrder;
    string currentOrderDirection;

    void Start()
    {
        playerDrink.value = 0;
        ordersPerTable.value.ForEach(order => order = 0);

        orderFeedbackRender = orderFeedbackUI.GetComponentInChildren<OrderFeedbackRender>();
    }

    void Update()
    {
        
    }

    public void Delivery(string direction)
    {

        if (playerDrink.value == 0)
        {
            orderFeedbackRender.Message("Nenhuma bebida em mãos", Color.white);
        }
        else
        {
            currentOrderDirection = direction;

            UpdateCurrentOrder();
            OrderHandler();

        }

    }

    void UpdateCurrentOrder()
    {

        int currentTableOrder;

        switch (playerGridPosition.value)
        {
            case 0:
                currentTableOrder = currentOrderDirection == "Left" ? 3 : 7;
                currentOrder = ordersPerTable.value[currentTableOrder];
                break;
            case 1:
                currentTableOrder = currentOrderDirection == "Left" ? 2 : 6;
                currentOrder = ordersPerTable.value[currentTableOrder];
                break;
            case 2:
                currentTableOrder = currentOrderDirection == "Left" ? 1 : 5;
                currentOrder = ordersPerTable.value[currentTableOrder];
                break;
            case 3:
                currentTableOrder = currentOrderDirection == "Left" ? 0 : 4;
                currentOrder = ordersPerTable.value[currentTableOrder];
                break;
        }

        
    }

    void OrderHandler()
    {
        if(currentOrder == playerDrink.value)
        {
            orderFeedbackRender.Message("Pedido correto", Color.green);
        }
        else
        {
            orderFeedbackRender.Message("Pedido incorreto", Color.red);
        }

        playerDrink.value = 0;
    }
}
