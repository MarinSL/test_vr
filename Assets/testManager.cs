using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testManager : MonoBehaviour
{
    public GameObject[] gates;
    private bool opened = false;

    void setOpened()
    {
        opened = true;
    }

    void Update()
    {
        if(opened)
        {
            Destroy(gameObject);
        }        
    }
}
