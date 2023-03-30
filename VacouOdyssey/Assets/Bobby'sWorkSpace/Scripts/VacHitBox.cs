using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacHitBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.position = Vector3.Lerp(collision.transform.position, (new Vector3(GetComponentInParent<Transform>().position.x, GetComponentInParent<Transform>().position.y, GetComponentInParent<Transform>().position.z)), 0.02f);
    }
}
