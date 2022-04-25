using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 mesafe;
    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + mesafe, Time.deltaTime);
    }
}
 