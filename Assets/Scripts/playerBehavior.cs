using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{
    float horizontalMove;
    float verticalMove;
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

       if (horizontalMove > 0.2f || horizontalMove < -0.2f)
        {
           myAnim.SetBool("walking_horizontal", true);
        }
       else
        {
            myAnim.SetBool("walking_horizontal", false);
        }
        if (verticalMove > 0.2f || verticalMove < -0.2f)
        {
            myAnim.SetBool("walking_vertical", true);
        }
        else
        {
            myAnim.SetBool("walking_vertical", false);
        }

    }

}
