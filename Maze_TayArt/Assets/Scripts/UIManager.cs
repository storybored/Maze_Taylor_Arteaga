using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text livesText;

    public PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        //This creates the lives UI
    }

    // Update is called once per frame
    void Update()
    {
        //This adds the lives to the top left
        livesText.text = "Lives: " + playerMovement.lives.ToString();
    }
}
