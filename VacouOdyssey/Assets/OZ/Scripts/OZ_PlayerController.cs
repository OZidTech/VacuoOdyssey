using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OZ_PlayerController : MonoBehaviour
{
    public UnityEvent onLeftPress;
    public UnityEvent onRightPress;
    public UnityEvent onUpPress;
    public UnityEvent onDownPress;
    public UnityEvent onMousePress;





    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 5);
        //Debug.DrawRay(transform.position, Vector3.right, Color.red, 5);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            onLeftPress.Invoke();
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            onRightPress.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            onUpPress.Invoke();
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            onDownPress.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            onMousePress.Invoke();
        }
    }
}
