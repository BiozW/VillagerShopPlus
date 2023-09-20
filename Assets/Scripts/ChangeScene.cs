using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void changeSceneToNewScene()
    {
        SceneManager.LoadScene("NewUIScene");
    }

    public void changeSceneToMainScene()
    {
        SceneManager.LoadScene("OldUIScene");
    }
}
