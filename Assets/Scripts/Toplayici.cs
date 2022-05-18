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

    [SerializeField] GameObject GoldPref;
    [SerializeField] GameObject GoldPanel;
    [SerializeField] Rigidbody rgb;

    [SerializeField] public AudioClip _Clip;
    void Start()
    {
        rgb = GetComponent<Rigidbody>();
        anaKüp = GameObject.Find("MainCube");
    }
    void Update()
    {
        anaKüp.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        rgb.velocity = new Vector3(h * 25, rgb.velocity.y);
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
            Instantiate(GoldPref, Camera.main.WorldToScreenPoint(transform.position), GoldPanel.transform.rotation, GoldPanel.transform);
            SoundManager.Instance.PlaySound(_Clip);
        }
        if (other.gameObject.tag == "Topla"&& other.gameObject.GetComponent<TolanabilirCube>().GetToplandiMi() == false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<TolanabilirCube>().ToplandiYap();
            other.gameObject.GetComponent<TolanabilirCube>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = anaKüp.transform;       
        }
        if (other.gameObject.tag == "Finish")
        {
            yukseklik += 2;
            other.gameObject.GetComponent<TolanabilirCube>().ToplandiYap();
            other.gameObject.GetComponent<TolanabilirCube>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = anaKüp.transform;
        }
    }
}
