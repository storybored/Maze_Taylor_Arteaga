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
    public int key_count = 0;
    public float speed = 10f;

    private Vector3 startPos;

    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        rigidbody = GetComponent<Rigidbody>();
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
        //bring the player back to the startPos
        transform.position = startPos;
        //Check if player has 0 lives
        if (lives == 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            LoseLife();
        }
        //print("Trigger");

        //locked door code
       else if (other.gameObject.tag == "Key")
        {
            key_count++;
            print("Picked up Key: " + key_count);
            other.gameObject.SetActive(false);
        }

        else if (other.gameObject.tag == "Oneup")
        {
            lives++;
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.tag == "Portal")
        {
            startPos = other.gameObject.GetComponent<Portal>().spawnPoint.transform.position;

            transform.position = startPos;
        }
    }
}
