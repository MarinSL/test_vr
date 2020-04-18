﻿using System.Collections;

using System.Collections.Generic;

using UnityEngine;



[RequireComponent(typeof(CapsuleCollider))]

public class ColliderFollowHeadset : MonoBehaviour
{
    private CapsuleCollider cc;
    public Transform camera;

     void Start()
    {
        cc = GetComponent<CapsuleCollider>();
    }

    private void LateUpdate()
    {
        Vector3 newCenter = transform.InverseTransformVector(camera.position - transform.position);
        cc.center = new Vector3(newCenter.x, cc.center.y, newCenter.z);
    }

}