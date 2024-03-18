using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    //where the platform will move too
    public Vector3 finishPos = Vector3.zero;

    //how fast the platform will move
    public float speed = 0.5f;

    //starting point of the platform's movement
    public Vector3 startPos;

    //percentage of completion
    private float trackPercent = 0;

    //current movement direction
    private int direction = -1;
    // Start is called before the first frame update
    void Start()
    {
        //starting position
        startPos = transform.position;
    }

    // Update is called once per frame
    private void Update()
    {
        //interpolate new location between start and finish positions
        trackPercent += direction * speed * Time.deltaTime;
        float x = (finishPos.x - startPos.x) * trackPercent + startPos.x;
        float y = (finishPos.y - startPos.y) * trackPercent + startPos.y;
        transform.position = new Vector3(x, y, startPos.z);

        //Reverses direction when it has finshed moving
        if ((direction == 1 && trackPercent > 0.9f) || (direction == -1 && trackPercent < 0.1f)) {
            direction *= -1;
        }
    }
}
