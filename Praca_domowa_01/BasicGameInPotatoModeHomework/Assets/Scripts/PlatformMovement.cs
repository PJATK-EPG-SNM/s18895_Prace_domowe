using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public Transform platformPoseYStart, platformPoseYFinish;
    public float speed = 1f;
    public Transform startPose;
    Vector3 nextPose;

    void Start()
    {
        nextPose = startPose.position;
    }

    void Update()
    {
        if (transform.position == platformPoseYStart.position)
        {
            nextPose = platformPoseYFinish.position;
        }
        if (transform.position == platformPoseYFinish.position)
        {
            nextPose = platformPoseYStart.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPose, speed * Time.deltaTime);
    }
}

