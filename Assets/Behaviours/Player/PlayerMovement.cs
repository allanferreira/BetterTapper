using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float speed = 1f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(string direction)
    {
        print(direction);
        //float distance = Time.deltaTime * speed;
        //transform.Translate(Vector3.left * distance);
    }
}
