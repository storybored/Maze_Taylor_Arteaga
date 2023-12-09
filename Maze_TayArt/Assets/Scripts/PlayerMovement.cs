using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Arteaga, Yasmine and Taylor, Madi
/// 12/08/23
/// Handles the player's movement.
/// </summary>

public class PlayerMovement : MonoBehaviour
{

    private bool canAttack;
    private bool isAttacking;
    private bool SeenSecret;

    //lives variable
    public int lives = 3;
    //key variable
    public int key_count = 0;
    //speed control
    public float speed = 10f;

    private Vector3 startPos;

    private Rigidbody rigidbody;

    private Material red;
    private Material yellow;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }

    //movement function
    //Gives the user control of the player
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


    //Controls the life tally
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

    //Function that controls triggered events
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

        if (other.gameObject.tag == "Win")
        {
            SceneManager.LoadScene(4);
        }
    }

    private void Attack()
    {
        if (Input.GetKey(KeyCode.R) && canAttack)
        {
            StartCoroutine(AttackMode());
        }
    }

    public IEnumerator AttackMode()
    {
        canAttack = false;
        isAttacking = true;
        GetComponent<MeshRenderer>().material = red;
        yield return new WaitForSeconds(1f);
        isAttacking = false;
        GetComponent<MeshRenderer>().material = yellow;
        yield return new WaitForSeconds(.5f);
        canAttack = true;
    }
}
