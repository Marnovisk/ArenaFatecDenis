//Denis Martins Dias - 004096223014

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = new Vector3(0, 0.15f, -0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        if(target)
        {
            transform.position = target.position + offset;
            transform.LookAt(target);
        }
    }
}
