using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickObjectScript : MonoBehaviour
{
    public UnityEvent onMouseDown;

    private void OnMouseDown()
    {
        onMouseDown.Invoke();
    }
}
