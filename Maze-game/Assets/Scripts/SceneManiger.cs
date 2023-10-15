using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManiger : MonoBehaviour
{
    public int nextSceneName = 1;

    public void ChangeScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
