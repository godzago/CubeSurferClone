using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] int myCoin;
    [SerializeField] Text YourScore;
    [SerializeField] GameObject FinishScore;
    [SerializeField] GameObject Silider;
    [SerializeField] GameObject CurrnetScore;
    void Start()
    {
        myCoin = PlayerPrefs.GetInt("Mustafa");
    }
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish2x")
        {
            Time.timeScale = 0;
            myCoin *= 2;
            YourScore.text = myCoin.ToString();
            FinishScore.SetActive(true);
            Silider.SetActive(false);
            CurrnetScore.SetActive(false);
        }
        if (other.gameObject.tag == "Finish3x")
        {
            Time.timeScale = 0;
            myCoin *= 3;
            YourScore.text = myCoin.ToString();
            FinishScore.SetActive(true);
            Silider.SetActive(false);
            CurrnetScore.SetActive(false);
        }
        if (other.gameObject.tag == "Finish4x")
        {
            Time.timeScale = 0;
            myCoin *= 4;
            YourScore.text = myCoin.ToString();
            FinishScore.SetActive(true);
            Silider.SetActive(false);
            CurrnetScore.SetActive(false);
        }
        if (other.gameObject.tag == "Finish5x")
        {
            Time.timeScale = 0;
            myCoin *= 5;
            YourScore.text = myCoin.ToString();
            FinishScore.SetActive(true);
            Silider.SetActive(false);
            CurrnetScore.SetActive(false);
        }
    }  
}
