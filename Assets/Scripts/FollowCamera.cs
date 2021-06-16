using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float dist = 50.0f;
    public float height = 20.0f;

    private void LateUpdate()
    {
        transform.position = target.position
                           - (target.forward * dist)
                           + (Vector3.up * height);
        transform.LookAt(target);
    }
}