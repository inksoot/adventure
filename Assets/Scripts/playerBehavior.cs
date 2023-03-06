using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{
    float horizontalMove;
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       horizontalMove = Input.GetAxis("Horizontal");
       if (horizontalMove > 0.2f || horizontalMove < -0.2f)
        {
           myAnim.SetBool("walking", true);
        }

        else
            {
            myAnim.SetBool("walking", false);
            }
    }

}
