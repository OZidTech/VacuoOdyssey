using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suckUp : MonoBehaviour
{
    public GameObject vacuum; 

    // Start is called before the first frame update
    void Start()
    {
        vacuum.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            vacuum.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            vacuum.SetActive(false);
        }
    }
}
