using System.Collections;
using UnityEngine;

public class Chaser : MonoBehaviour
{
    public Transform targetTransform;
    public float speed = 7f;
    void Update()
    {
        Vector3 displacementFromTarget = targetTransform.position - transform.position;
        if (displacementFromTarget.magnitude < 1.5)
            return;

        Vector3 velocity = displacementFromTarget.normalized * speed;
        transform.Translate(velocity * Time.deltaTime);
    }
}
