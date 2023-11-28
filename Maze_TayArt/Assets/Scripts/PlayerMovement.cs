using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Arteaga, Yasmine and Taylor, Madi
/// 11/16/23
/// Handles the player's movement.
/// </summary>

public class PlayerMovement : MonoBehaviour
{
    public int lives = 3;

    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Movement()
    {
        
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

    private void LoseLife()
    {
        lives--;
        //bring the player back to the startPost
        //transform.position = startPos;
        //Check if player has 0 lives
        //if (lives == 0)
        //{
         //   SceneManager.LoadScene(1);
        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            LoseLife();
        }

    }
}
