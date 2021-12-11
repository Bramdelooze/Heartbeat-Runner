using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnButtonPress : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (GetInput())
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    bool GetInput()
    {
        if (Input.GetKeyDown(KeyCode.N))
            return true;
        else
            return false;
    }

    public void NextScene()
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
