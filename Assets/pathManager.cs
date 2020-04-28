using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathManager : MonoBehaviour
{
    public GameObject[] pathBulbs;
    int curActiveId = 0;
    GameObject curActive;

    void Start()
    {
        if (pathBulbs.Length < 1) {
            Debug.Log("Add bulbs to the PathManager");
            return;
        } else
        {
            curActive = pathBulbs[0];
        }

        for(int i=1; i<pathBulbs.Length; ++i)
        {
            pathBulbs[i].SetActive(false);
        }
    }

    void Update()
    {
        if (curActive.GetComponent<LightOnCollision>().isTriggered())
        {
            curActiveId++;
            if (curActiveId < pathBulbs.Length) {
                curActive = pathBulbs[curActiveId];
                curActive.SetActive(true);
            }
            else return;
        }
    }
}
