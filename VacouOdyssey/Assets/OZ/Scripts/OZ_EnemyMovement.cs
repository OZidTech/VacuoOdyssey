using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OZ_EnemyMovement : MonoBehaviour
{
    [SerializeField]
    public enum Ability
    {
        sword,
        punch,
        lazer
    };

    public Ability ability;
    
}
