using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float speed = 8f;
    float distance;
    float gridDistance = 0.81f;
    Vector3 nextGrid;

    void Start()
    {
        distance = Time.fixedDeltaTime * speed;
        nextGrid = new Vector3(transform.localPosition.x, transform.localPosition.y);
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.localPosition, nextGrid, distance);
    }

    public void Move(string direction)
    {

        print(direction);
        switch (direction)
        {
            case ("Up"):

                if (CanMove("Up"))
                {
                    MoveInGrid("Up");
                }

                break;
            case ("Left"):

                Delivery("Left");

                break;
            case ("Right"):

                Delivery("Right");

                break;
            case ("Down"):

                if (CanMove("Down"))
                {
                    MoveInGrid("Down");
                }

                break;
        }

    }

    void Delivery(string direction)
    {

    }

    bool CanMove(string direction)
    {
        bool value;
        if (direction == "Up")
        {
            value = transform.localPosition.y >= 2.1 ? false : true;
        }
        else if (direction == "Down")
        {
            value = transform.localPosition.y <= -0.33 ? false : true;
        }
        else
        {
            value = true;
        }

        return value;

    }

    void MoveInGrid(string direction)
    {

        if (direction == "Up")
        {
            nextGrid = new Vector3(transform.localPosition.x, transform.localPosition.y + gridDistance);
        }
        if (direction == "Down")
        {
            nextGrid = new Vector3(transform.localPosition.x, transform.localPosition.y - gridDistance);
        }

    }
}
