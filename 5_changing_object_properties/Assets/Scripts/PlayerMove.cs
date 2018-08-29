using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private CharacterController charControl;

    public float walkSpeed;

    void Awake()
    {
        charControl = GetComponent<CharacterController>();
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moveDirectionRight = transform.right * horizontal * walkSpeed;
        Vector3 moveDirectionForward = transform.forward * vertical * walkSpeed;

        charControl.SimpleMove(moveDirectionRight);
        charControl.SimpleMove(moveDirectionForward);
    }

}
