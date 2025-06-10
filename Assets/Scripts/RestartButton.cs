using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public string scene;

    public void RestartGame()
    {
        SceneManager.LoadScene(scene);
    }
}
