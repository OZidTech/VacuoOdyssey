using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OZ_EnemyMovement : MonoBehaviour
{
    public void EnemyJump()
    {
        transform.position += Vector3.up;
    }
}
