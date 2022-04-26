using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toplayici : MonoBehaviour
{
    GameObject anaK�p;
    int yukseklik;
    void Start()
    {
        anaK�p = GameObject.Find("MainCube");
    }

    void Update()
    {
        anaK�p.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }
    public void yukseklikAzalt()
    {
        yukseklik --;
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Topla"&& other.gameObject.GetComponent<TolanabilirCube>().GetToplandiMi() == false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<TolanabilirCube>().ToplandiYap();
            other.gameObject.GetComponent<TolanabilirCube>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = anaK�p.transform;
        }
    }
}