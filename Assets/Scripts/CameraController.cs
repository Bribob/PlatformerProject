using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //gets the target for the camera to follow
    public Transform target;
    public float smoothTime = 0.2f;
    public Vector3 velocity = Vector3.zero;
    private void LateUpdate() {
        //moves the camera with the target
        //transform.position = new Vector3(target.position.x, target.position.y, target.position.z);
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, target.position.z - 10);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
