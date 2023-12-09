using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;/// <summary>
/// Arteaga, Yasmine and Taylor, Madi
/// 12/08/23
/// Handles scene switching
/// </summary>

public class StartScript : MonoBehaviour
{

    /// <summary>
    /// move to the desired scene
    /// </summary>
    /// <param name="sceneIndex"></param>
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
