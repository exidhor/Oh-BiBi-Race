using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform FollowedTarget;

    void Update()
    {
        transform.position = new Vector3(FollowedTarget.position.x, 
                                         FollowedTarget.position.y, 
                                         transform.position.z);
    }
}