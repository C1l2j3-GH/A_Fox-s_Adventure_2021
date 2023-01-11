using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //public float startWaitTime;
    //private float waitTime; //Enemy's waiting time before moving to a new location

    //public Transform[] moveSpots; //Enemy's moving path
    //private int randomSpot;

    public float moveSpeed;//Enemy's moving speed
    public float maxPositionX;
    public float minPositionX;
    public bool MovingRight = false;
    private Rigidbody2D RDBody2D;

    public GameObject PlayerObject;
    public GameObject GameOverMenu;

    //private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        //waitTime = startWaitTime;
        //randomSpot = Random.Range(0, moveSpots.Length);
        RDBody2D = transform.GetComponent<Rigidbody2D>();
        //animator = transform.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //Animating the enemies
        //animator.SetBool("MovingRight", MovingRight);

        if (transform.position.x > maxPositionX)
        {
            MovingRight = false;
            //transform.Rotate(0f, 180f, 0f);
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (transform.position.x < minPositionX)
        {
            MovingRight = true;
            //transform.Rotate(0f, 180f, 0f);
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        if (MovingRight == true)
        {
            RDBody2D.velocity = new Vector2(moveSpeed, 0);
        }
        else
        {
            RDBody2D.velocity = new Vector2(-moveSpeed, 0);
        }
    }

}
    // Update is called once per frame
    //void Update()
    //{
    //    transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

    //    if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
    //    {
    //        if (waitTime <= 0)
    //        {
    //            randomSpot = Random.Range(0, moveSpots.Length);
    //            waitTime = startWaitTime;
    //        }
    //        else { waitTime -= Time.deltaTime; }
    //    }

    
    
    
    
//    }
//}
