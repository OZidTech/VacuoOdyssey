using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VacHitBox : MonoBehaviour
{
    Animation badGuy;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            collision.transform.position = Vector3.Lerp(collision.transform.position, transform.parent.position, 0.02f);

            //collision.transform.Translate(transform.position * 2 *Time.deltaTime);
            collision.transform.Rotate(Vector3.fwd * 100  * Time.deltaTime);
            if(collision.gameObject.GetComponent<OZ_Ability>().ability == OZ_Ability.Ability.sword)
            {
                player.GetComponent<OZ_Ability>().ability = OZ_Ability.Ability.sword;
            }
            else if(collision.gameObject.GetComponent<OZ_Ability>().ability == OZ_Ability.Ability.punch)
            {

                player.GetComponent<OZ_Ability>().ability = OZ_Ability.Ability.punch;
            }
            else if(collision.gameObject.GetComponent<OZ_Ability>().ability == OZ_Ability.Ability.lazer)
            {

                player.GetComponent<OZ_Ability>().ability = OZ_Ability.Ability.lazer;
            }
            else if(collision.gameObject.GetComponent<OZ_Ability>().ability == OZ_Ability.Ability.None)
            {

                player.GetComponent<OZ_Ability>().ability = OZ_Ability.Ability.None;
            }
            Destroy(collision.gameObject, 2.0f);


            //Debug.Log(collision.gameObject.name);
        }
        
        
    }



}
