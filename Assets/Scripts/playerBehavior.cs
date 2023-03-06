using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBehavior : MonoBehaviour
{
    float horizontalMove;
    float verticalMove;

    bool keyAcquired = false;
    bool gameEnd = false;
    public GameObject npcText;
    public GameObject trappedNPCtext;

    float movementSpd = 2;
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        npcText.SetActive(false);
        trappedNPCtext.SetActive(false);
        //myBody = GetComponent<Rigidbody2D>();
        //pointing to the specific RigidBody2D in the chara
        myAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            newPos.y += movementSpd * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPos.y -= movementSpd * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            newPos.x -= movementSpd * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            newPos.x += movementSpd * Time.deltaTime;
        }
        transform.position = newPos;

    

        //horizontalMove = Input.GetAxis("Horizontal");
        //verticalMove = Input.GetAxis("Vertical");
        //animation later

        //if (horizontalMove > 0.2f || horizontalMove < -0.2f)
        // {
        //    myAnim.SetBool("walking_horizontal", true);
        // }
        //else
        // {
        //     myAnim.SetBool("walking_horizontal", false);
        // }
        // if (verticalMove > 0.2f || verticalMove < -0.2f)
        // {
        //     myAnim.SetBool("walking_vertical", true);
        // }
        // else
        // {
        //     myAnim.SetBool("walking_vertical", false);
        // }

    }
    void OnCollisionEnter2D(Collision npcCollision)
    {
        // physical collision triggers dialogue here
        //probably might need to change once key is obtained? apparently
        //that's a thing
    }

    void OnCollisionEnter2D(Collision2D lockedNPCcollision)
    {
       //physical collision triggers dialogue here
    }

}
