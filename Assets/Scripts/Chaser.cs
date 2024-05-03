using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Transform targetTransform;
    private UnityEngine.Vector3 directionToTarget;
    float speed = 7f;
    void Update()
    {
        directionToTarget = (targetTransform.position - transform.position).normalized;
        UnityEngine.Vector3 velocity = directionToTarget * speed * Time.deltaTime;
        transform.Translate(velocity);
    }
}
