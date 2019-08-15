using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float speed = 8f;
    float distance;
    List<Vector3> grid;
    public ListFloatScriptable movementGridY;
    public IntegerScriptable playerGridPosition;
    PlayerDrinkDelivery playerDrinkDelivery;
    public GameObject orderFeedbackUI;
    OrderFeedbackRender orderFeedbackRender;


    void Start()
    {
        orderFeedbackRender = orderFeedbackUI.GetComponentInChildren<OrderFeedbackRender>();

        distance = Time.fixedDeltaTime * speed;
        playerGridPosition.value = 0;

        playerDrinkDelivery = gameObject.GetComponent<PlayerDrinkDelivery>();

        grid = new List<Vector3> {
            new Vector3(transform.position.x, movementGridY.value[0]),
            new Vector3(transform.position.x, movementGridY.value[1]),
            new Vector3(transform.position.x, movementGridY.value[2]),
            new Vector3(transform.position.x, movementGridY.value[3])
        };
    }

    void Update()
    {
        MoveToCurrentPosition();
    }

    void MoveToCurrentPosition()
    {
        transform.position = Vector3.MoveTowards(transform.position, grid[playerGridPosition.value], distance);
    }

    public void Move(string direction)
    {
        orderFeedbackRender.Clear();

        if (direction == "Up" || direction == "Down")
        {
            if(CanMove(direction)) MoveToDirection(direction);
        }
        else if (direction == "Left" || direction == "Right")
        {
            playerDrinkDelivery.Delivery(direction);
        }

    }

    bool CanMove(string direction)
    {
        bool res = false;

        if (direction == "Up")
        {
            res = playerGridPosition.value + 1 <= 3;
        }
        else if (direction == "Down")
        {
            res = playerGridPosition.value - 1 >= 0;
        }

        return res;            
    }

    void MoveToDirection(string direction)
    {

        if (direction == "Up")
        {
            playerGridPosition.value++;
        }
        else if (direction == "Down")
        {
            playerGridPosition.value--;
        }

    }

}