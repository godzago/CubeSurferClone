using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TolanabilirCube : MonoBehaviour
{
    bool ToplandiMi;
    int index;
    public Toplayici Toplayici;
    void Start()
    {
        ToplandiMi = false;
    }

    void Update()
    {
        if(ToplandiMi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }       
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel")
        {
            Toplayici.yukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool GetToplandiMi()
    {
        return ToplandiMi;
    }
    public void ToplandiYap()
    {
        ToplandiMi = true;
    }
    public void IndexAyarla(int index)
    {
        this.index = index; 
    }
}
