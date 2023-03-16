using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class OZ_Enemy_AI : MonoBehaviour
{
    public UnityEvent onJump;
    Collider col;
    Bounds bounds;



    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider>();
        bounds = GetComponent<Bounds>();
    }

    // Update is called once per frame
    void Update()
    {

        
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.left) * 1000, Color.red);
    }


    struct RayCastProjection{
          
    
    };

}
