using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    bool hover = false;

    public Rigidbody2D myBody;

    void Update()
    {
        if (Input.GetMouseButton(0) && hover)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosition;
            myBody.gravityScale = 0;
        }
        else
        {
            myBody.gravityScale = 1;
        }
    }

    void OnMouseEnter()
    {
        hover = true;
    }

    void OnMouseExit()
    {
        hover = false;
        Debug.Log("False");
    }


/*    void OnMouseDown()
    {

    }*/
/*    Vector2 oldPosition;



    void OnMouseDown()
    {
        oldPosition = Input.mousePosition;
    }

    void OnMouseDrag()
    {
        Vector2 currentPosition = Input.mousePosition;
        Vector2 movedPosition = currentPosition - oldPosition;

        transform.position = movedPosition;
        oldPosition = currentPosition;
    }*/
}
