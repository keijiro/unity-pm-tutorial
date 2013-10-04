using UnityEngine;
using System.Collections;

public class CubeAnimation : MonoBehaviour
{
    Vector3 origin;

    void Start ()
    {
        origin = transform.position;
    }

    void Update ()
    {
        transform.position = origin + Vector3.up * Mathf.Sin (Time.time * 5.43f) * 5.0f;
        transform.localRotation =
            Quaternion.AngleAxis (Time.time * 180.0f, Vector3.up) *
            Quaternion.AngleAxis (Time.time * 77.0f, Vector3.right);
    }
}