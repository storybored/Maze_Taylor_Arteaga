using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
/// <summary>
/// Arteaga, Yasmine and Taylor, Madi
/// 11/16/23
/// Handles the player's movement.
/// </summary>

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement()
    {
        if (Input.GetKey("a"))
        {
            Debug.Log("Inputed the a key");
            transform.position += Vector3.left * speed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            Debug.Log("Inputed the d key");
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

        if (Input.GetKey("w"))
        {
            Debug.Log("Inputed the w key");
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            Debug.Log("Inputed the s key");
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
    }
}
