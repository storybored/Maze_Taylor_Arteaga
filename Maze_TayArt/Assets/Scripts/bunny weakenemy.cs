using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Arteaga, Yasmine and Taylor, Madi
/// 12/07/23
/// Controls bunny enemy
/// </summary>
public class bunnyweakenemy : MonoBehaviour
{
    //control how fast the enemy moves
    public float speed;

    //control the direction the enemy is moving
    public bool movingLeft;

    //get the tranform positions of the left and right limits
    private Vector3 leftPosition, rightPosition;
    private Vector3 FrontPos;
    private Vector3 BackPos;


    //get the objects that represent the left and right limits (walls)
    public GameObject leftLimit, rightLimit;
    public GameObject ForwardPoint;
    public GameObject BackmostPoint;

    public bool GoingBackward;

    [Header("Move Forward or Left?")]
    public bool MoveLeftRight;

    private void Start()
    {
        leftPosition = leftLimit.transform.position;
        rightPosition = rightLimit.transform.position;
        FrontPos = ForwardPoint.transform.position;
        BackPos = BackmostPoint.transform.position;
    }

    /// <summary>
    /// make the enemy move left and right
    /// </summary>

    // Update is called once per frame
    private void Update()
    {

        whichDirection();

    }

    //makes the enemy move left and right
    private void whichDirection()
    {
        if (MoveLeftRight)
        {
            if (movingLeft)
            {
                //once enemy reaches left point left turns false
                if (transform.position.x <= leftPosition.x)
                {
                    movingLeft = false;
                }

                else
                {
                    transform.position += Vector3.left * speed * Time.deltaTime;
                }
            }
            else
            {
                //once the enemy reaches rightPositionition, movingLeft is true
                if (transform.position.x >= rightPosition.x)
                {
                    movingLeft = true;
                }
                else
                {
                    transform.position += Vector3.right * speed * Time.deltaTime;
                }
            }
        }
        else if (!MoveLeftRight)
        {
            if (GoingBackward)
            {
                //once enemy reaches left point left turns false
                if (transform.position.z <= FrontPos.z)
                {
                    GoingBackward = false;
                }

                else
                {
                    transform.position += Vector3.back * speed * Time.deltaTime;
                }
            }
            else
            {
                //once the enemy reaches rightPositionition, movingLeft is true
                if (transform.position.z >= BackPos.z)
                {
                    GoingBackward = true;
                }
                else
                {
                    transform.position += Vector3.forward * speed * Time.deltaTime;
                }
            }
        }
    }
}
