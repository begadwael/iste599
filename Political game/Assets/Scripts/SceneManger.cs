using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManger : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
