using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CoinManager : MonoBehaviour
{
    [SerializeField] float coin;
    [SerializeField] Text cointext;
    void Start()
    {
        coin = 0;
    }
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        coin++;
    }
}
