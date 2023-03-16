using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class OZ_PlayerMovement : MonoBehaviour
{
    float speed = 10f;

    public void MoveLeft()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    public void MoveRight()
    {

    }

    public void MoveUp()
    {

    }

    public void MoveDown()
    {

    }
}
