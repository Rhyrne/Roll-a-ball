using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject ball;
    public Vector3 vector;
    void Start()
    {
        vector = transform.position - ball.transform.position;
    }

    void LateUpdate()
    {
        transform.position = ball.transform.position + vector;
    }
}
