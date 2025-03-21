using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAim : MonoBehaviour
{
    [Header("Layers")]
    public LayerMask groundLayer;
    public Ray ray;

    public float velocity = 5.0f;

    public RaycastHit hit;

    private Vector3 MousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePos = Input.mousePosition;
        
        
        //  ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        //     Debug.DrawRay(ray.origin, ray.direction * 1000, Color.red);            

        //     if(Physics.Raycast(ray, out hit, Mathf.Infinity, groundLayer))
        //     {
        //         if (hit.collider.CompareTag("Ground"))
        //         {
        //             //Debug.Log(hit.point);
        //         }
        //     }
    }

    private void FixedUpdate()
    {         
        float MouseYPos = MousePos.x - transform.position.x;
        Quaternion rot = Quaternion.Euler(0, MouseYPos, 0);
        float Sense = Time.deltaTime * velocity;
        transform.rotation = Quaternion.Lerp(rot, transform.rotation, Sense);

        //Vector3 LookAt = MousePos - transform.position;
        //Quaternion rot = Quaternion.LookRotation(LookAt);
    }
}
