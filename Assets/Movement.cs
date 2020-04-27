using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Movement : MonoBehaviour
{
    public SteamVR_Action_Vector2 input;
    public SteamVR_Action_Single speedMultiplyer;
    public float speed = 1;
    CharacterController cc;
    Rigidbody rb;
    //public float speed;

    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Player.instance.hmdTransform.TransformDirection(new Vector3(input.axis.x, 0, input.axis.y));
        cc.Move(speed * speedMultiplyer.axis * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up));
        
        rb.MovePosition(transform.position + (speed * speedMultiplyer.axis * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up)));
        cc.Move(speed * speedMultiplyer.axis * Time.deltaTime * Vector3.ProjectOnPlane(direction, Vector3.up));
    }
}