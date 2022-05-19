using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    [SerializeField] int myCoin;
    [SerializeField] Text YourScore;
    void Start()
    {
        myCoin = PlayerPrefs.GetInt("puan");
    }
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        YourScore.text = myCoin.ToString();
    }
   
}
