using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateOnCollision : MonoBehaviour
{
    GameObject parent;

    private void Start()
    {
       gameObject.GetComponentInParent<testManager>().SendMessage("setOpened");
    }

}
