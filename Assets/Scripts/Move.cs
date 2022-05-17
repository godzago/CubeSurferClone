using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float ileriGitme;
    [SerializeField] private float yanaGitme;
    void Update()
    {
        float yatakEksen = Input.GetAxis("Horizontal") * yanaGitme *Time.deltaTime;
        this.transform.Translate(yatakEksen, 0, ileriGitme * Time.deltaTime);
    }
}
