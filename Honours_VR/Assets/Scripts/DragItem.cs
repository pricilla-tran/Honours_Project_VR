using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragItem : MonoBehaviour
{
    private bool isDragged = false;
    //private Vector3 mouseDragStartPosition;
    //private Vector3 spriteDragStartPosition;

    private void OnMouseDown()
    {
        isDragged = true;
        //mouseDragStartPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //spriteDragStartPosition = transform.localPosition;
    }

    private void OnMouseUp()
    {
        isDragged = false;
    }

    void Update()
    {
        if (isDragged)
        {
            Vector2 mousePosition = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
            transform.Translate(mousePosition);
        }   
    }

    
}
