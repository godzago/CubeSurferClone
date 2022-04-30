using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Toplayici : MonoBehaviour
{
    [SerializeField] float coin;
    [SerializeField] Text cointext;
    GameObject anaKüp;
    int yukseklik;
    void Start()
    {
        anaKüp = GameObject.Find("MainCube");
    }

    void Update()
    {
        anaKüp.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }
    public void yukseklikAzalt()
    {
        yukseklik --;
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "coin")
        {
            coin++;
            cointext.text = coin.ToString();
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Topla"&& other.gameObject.GetComponent<TolanabilirCube>().GetToplandiMi() == false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<TolanabilirCube>().ToplandiYap();
            other.gameObject.GetComponent<TolanabilirCube>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = anaKüp.transform;
        }
    }
}
