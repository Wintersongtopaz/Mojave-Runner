using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        // If an instance of an obstacle is offscreen, destroy it. Otherwise, don't destroy it.
        if (instance)
        {
            Destroy(this);
        }

        else
        {
            instance = this;
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
