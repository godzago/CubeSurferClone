using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScripts : MonoBehaviour
{
    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }
}
