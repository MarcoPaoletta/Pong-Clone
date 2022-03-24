using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryPlayer1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadMenu", 3);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
