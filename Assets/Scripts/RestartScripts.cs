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
    public GameObject SwipeToRun;
    public GameObject SliderALL;
    public GameObject AllScore;
    public GameObject RestartALL;
    public Animator Myanimator;
    public void Start()
    {
        Myanimator.SetBool("SwipeToRunAnim", true);
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
    public void StartGame()
    {
        Time.timeScale = 1;
        Myanimator.SetBool("SwipeToRunAnim", false);
        SwipeToRun.SetActive(false);
        SliderALL.SetActive(true);
        AllScore.SetActive(true);
        RestartALL.SetActive(true);
    }
}
