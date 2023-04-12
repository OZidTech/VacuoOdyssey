using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OZ_Sword : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(GetComponent<OZ_Ability>().ability == OZ_Ability.Ability.sword)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {

            }
        }
    }




}
