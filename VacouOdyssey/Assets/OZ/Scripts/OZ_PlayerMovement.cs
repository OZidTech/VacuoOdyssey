using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class OZ_PlayerMovement : MonoBehaviour
{
    float speed = 10f;
    float jumpSpeed = 80f;
    Ray2D playerRay;

    public void MoveLeft()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    public void MoveRight()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    public void MoveUp()
    {
        transform.Translate(Vector2.up * jumpSpeed * Time.deltaTime);
    }

    public void MoveDown()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        //if(collision.gameObject.tag == "Pushable")
        //{
        //    collision.transform.position += (collision.transform.position - transform.position );
        //}
    }


}
