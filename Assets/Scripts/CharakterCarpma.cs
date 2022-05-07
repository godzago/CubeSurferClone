using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharakterCarpma : MonoBehaviour
{
    public Animator animator;

    public void ChrakterCarpmaAnim()
    {
        animator.SetBool("IsCarpma", true);
    }
}
