using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    float ver;
    float hor;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       ver = Input.GetAxis("Vertical");
       hor =Input.GetAxis("Horizontal");
       CamBasedMove();
    }

    void VectorMove()
    {
        pos = transform.position;
        pos.x += moveSpeed * hor * Time.deltaTime;
        pos.z += moveSpeed * ver * Time.deltaTime;
        transform.position = pos;
    }
    void CamBasedMove()
    {
        Vector3 CameraForward = Camera.main.transform.forward;
        Vector3 CameraRight = Camera.main.transform.right;

        CameraForward.y = 0;
        CameraForward = CameraForward.normalized;
        CameraRight.y = 0;
        CameraRight = CameraRight.normalized;

        // Rotate the Input Vectors 
        Vector3 forwardRelativeMovementVector = ver * CameraForward; 
        Vector3 rightRelativeMovementVector = hor * CameraRight; 
        // Create Camera-Relative Movement Vector 
        Vector3 cameraRelativeMovement = forwardRelativeMovementVector + rightRelativeMovementVector;
        // Move in world space 
        this.transform.Translate(cameraRelativeMovement * moveSpeed * Time.deltaTime, Space.World);
    }
}
