using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float speed = 8f;
    float distance;
    List<Vector3> grid;
    int currentPosition;


    void Start()
    {
        distance = Time.fixedDeltaTime * speed;
        currentPosition = 0;

        grid = new List<Vector3> {
            new Vector3(transform.position.x, -0.33f),
            new Vector3(transform.position.x, 0.48f),
            new Vector3(transform.position.x, 1.29f),
            new Vector3(transform.position.x, 2.1f)
        };
    }

    void Update()
    {
        MoveToCurrentPosition();
    }

    void MoveToCurrentPosition()
    {
        transform.position = Vector3.MoveTowards(transform.position, grid[currentPosition], distance);
    }

    public void Move(string direction)
    {

        if (direction == "Up" || direction == "Down")
        {
            if(CanMove(direction)) MoveToDirection(direction);
        }
        else if (direction == "Left" || direction == "Right")
        {
            Devilery(direction);
        }

    }

    bool CanMove(string direction)
    {
        bool res = false;

        if (direction == "Up")
        {
            res = currentPosition + 1 <= 3;
        }
        else if (direction == "Down")
        {
            res = currentPosition - 1 >= 0;
        }

        return res;            
    }

    void MoveToDirection(string direction)
    {

        if (direction == "Up")
        {
            currentPosition++;
        }
        else if (direction == "Down")
        {
            currentPosition--;
        }

    }

    void Devilery(string direction)
    {

    }

}