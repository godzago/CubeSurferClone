using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Toplayici : MonoBehaviour
{
    [SerializeField] int coin;
    [SerializeField] Text cointext;

    [SerializeField] GameObject anaKüp;
    [SerializeField] int yukseklik;

    [SerializeField] GameObject GoldPref;
    [SerializeField] GameObject GoldPanel;
    [SerializeField] Rigidbody rgb;

    [SerializeField] public AudioClip _Clip;

    [SerializeField] ParticleSystem particle;

    [SerializeField] Text YourScore;
    [SerializeField] GameObject FinishScore;
    [SerializeField] GameObject Silider;
    [SerializeField] GameObject CurrnetScore;
    void Start()
    {
        Time.timeScale = 0;
        rgb = GetComponent<Rigidbody>();
        anaKüp = GameObject.Find("MainCube");
        particle.Stop();
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
            PlayerPrefs.SetInt("Mustafa", coin);
            cointext.text = coin.ToString();
            Destroy(other.gameObject);
            Instantiate(GoldPref, Camera.main.WorldToScreenPoint(transform.position), GoldPanel.transform.rotation, GoldPanel.transform);
            particle.transform.position = gameObject.transform.position;
            particle.Play();
            SoundManager.Instance.PlaySound(_Clip);            
        }
        if (other.gameObject.tag == "Topla"&& other.gameObject.GetComponent<TolanabilirCube>().GetToplandiMi() == false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<TolanabilirCube>().ToplandiYap();
            other.gameObject.GetComponent<TolanabilirCube>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = anaKüp.transform;       
        }
        if (other.gameObject.tag == "Finish2x" && yukseklik == 1)
         {
             Time.timeScale = 0;
             coin *= 2;
             YourScore.text = coin.ToString();
             FinishScore.SetActive(true);
             Silider.SetActive(false);
             CurrnetScore.SetActive(false);
         }
         if (other.gameObject.tag == "Finish3x" && yukseklik == 2)
         {
             Time.timeScale = 0;
             coin *= 3;
             YourScore.text = coin.ToString();
             FinishScore.SetActive(true);
             Silider.SetActive(false);
             CurrnetScore.SetActive(false);
         }
        if (other.gameObject.tag == "Finish4x" && yukseklik == 3)
        {
            Time.timeScale = 0;
            coin *= 4 ;
            YourScore.text = coin.ToString();
            FinishScore.SetActive(true);
            Silider.SetActive(false);
            CurrnetScore.SetActive(false);
        }
        if (other.gameObject.tag == "Finish5x" && yukseklik == 4)
        {
            Time.timeScale = 0;
            coin *= 5;
            YourScore.text = coin.ToString();
            FinishScore.SetActive(true);
            Silider.SetActive(false);
            CurrnetScore.SetActive(false);
        }

    }
}
