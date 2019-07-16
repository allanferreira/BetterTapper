using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeWatcher : MonoBehaviour, IDragHandler, IEndDragHandler
{

    public GameObject player;
    PlayerMovement playerMovement;

    void Start()
	{
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        // needs to be empty
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector3 dragVectorDirection = (eventData.position - eventData.pressPosition).normalized;
        playerMovement.Move(GetDragDirection(dragVectorDirection));
    }

    private string GetDragDirection(Vector3 dragVector)
    {
        float positiveX = Mathf.Abs(dragVector.x);
        float positiveY = Mathf.Abs(dragVector.y);

        string draggedDir;
        if (positiveX > positiveY)
        {
            draggedDir = dragVector.x > 0 ? "Right" : "Left";
        }
        else
        {
            draggedDir = dragVector.y > 0 ? "Up" : "Down";
        }
        
        return draggedDir;
    }
}