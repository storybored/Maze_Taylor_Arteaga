using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Arteaga, Yasmine and Taylor, Madi
/// 11/16/23
/// Handles the player's rotation.
/// </summary>

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Start
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            transform.Rotate(Vector3.up * 90);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(Vector3.up * 270);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(Vector3.up * 180);
        }

        if (Input.GetKey(KeyCode.W))
        {
            //transform.forward is the forward direction of an object based on where it's facing.
            transform.position += transform.right * Time.deltaTime * 2f;
        }


    }
}
