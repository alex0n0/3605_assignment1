using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour {

    private CharacterController charControl;
    public float walkSpeed;
    public Text message;

    void Awake()
    {
        charControl = GetComponent<CharacterController>();
        message.text = "";
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal > 0 && vertical > 0)
        {
            message.text = "right + forward";
        }
        else if (horizontal > 0 && vertical < 0)
        {
            message.text = "right + down";
        }
        else if (horizontal < 0 && vertical > 0)
        {
            message.text = "left + forward";
        }
        else if (horizontal < 0 && vertical < 0)
        {
            message.text = "left + down";
        }
        else if (horizontal > 0)
        {
            message.text = "right";
        }
        else if (vertical > 0)
        {
            message.text = "forward";
        }
        else if (horizontal < 0)
        {
            message.text = "left";
        }
        else if (vertical < 0)
        {
            message.text = "back";
        }
        else
        {
            message.text = "no input";
        }

        Vector3 moveDirectionRight = transform.right * horizontal * walkSpeed;
        Vector3 moveDirectionForward = transform.forward * vertical * walkSpeed;

        charControl.SimpleMove(moveDirectionRight);
        charControl.SimpleMove(moveDirectionForward);
    }

}
