using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void changeSceneToNewScene()
    {
        SceneManager.LoadScene("NewScene");
    }

    public void changeSceneToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
}
