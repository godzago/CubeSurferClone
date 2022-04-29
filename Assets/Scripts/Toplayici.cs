using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Toplayici : MonoBehaviour
{
    [SerializeField] float coin;
    [SerializeField] Text cointext;
    public GameObject CoinNesnesi;
    GameObject anaKüp;
    int yukseklik;
    void Start()
    {
        CoinNesnesi = GameObject.Find("coin");
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
            Destroy(CoinNesnesi);
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
