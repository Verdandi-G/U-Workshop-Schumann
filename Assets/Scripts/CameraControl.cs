using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour
{
    private Vector3 LookVector = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LookVector.x = -Input.GetAxis("Mouse Y");
        transform.Rotate(LookVector * Time.deltaTime * 100);
    }
}
