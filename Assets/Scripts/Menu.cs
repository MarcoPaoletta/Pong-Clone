using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PlayerVSIA()
    {
        SceneManager.LoadScene("PlayerVSIa");
    }

    public void PlayerVSPlayer()
    {
        SceneManager.LoadScene("PlayerVSPlayer");
    }
}
