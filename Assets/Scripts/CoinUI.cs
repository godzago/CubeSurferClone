using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinUI : MonoBehaviour
{
    public Transform GoldPanel;
    Sequence GoldAnimation;
    public Rigidbody rgb;
    void Start()
    {
        Animation();
    }
    public void Animation() 
    {
        rgb = GetComponent<Rigidbody>();
        GoldPanel = GameObject.FindGameObjectWithTag("GoldPanel").transform;
        GoldAnimation = DOTween.Sequence();

        GoldAnimation.Append(transform.DOMove(GoldPanel.position, 2).SetEase(Ease.InOutBack)).OnComplete(() => Destroy(gameObject));
    }
}
