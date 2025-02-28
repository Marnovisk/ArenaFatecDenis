using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{
    public Vector2 eixo;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        eixo.x += Input.GetAxis("Mouse X");
        eixo.y += Input.GetAxis("Mouse Y");

        transform.localRotation = Quaternion.Euler(-eixo.y, eixo.x, 0);
    }
}
