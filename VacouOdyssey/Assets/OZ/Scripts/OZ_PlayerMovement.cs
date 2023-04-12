using System.Collections;
using System.Collections.Generic;
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
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    public void MoveUp()
    {

    }

    public void MoveDown()
    {

    }
}
