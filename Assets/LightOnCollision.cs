using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger " + other.gameObject.tag);
        if (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("MainCamera"))
            Destroy(gameObject);
    }
}
