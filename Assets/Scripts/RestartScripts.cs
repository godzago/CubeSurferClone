using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScripts : MonoBehaviour
{
    public Slider slider;
    public float maxDistance;
    public GameObject finisLine;
    public Transform myCharactertransform;

    public void Start()
    {
        maxDistance = finisLine.transform.position.z - myCharactertransform.transform.position.z;
    }
    public void Update()
    {
         float distance = finisLine.transform.position.z - myCharactertransform.transform.position.z;
        slider.value = 1 - (distance / maxDistance);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }
}
