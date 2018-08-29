using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public int scene;
    private CharacterController charControl;

    public float walkSpeed;

    void Awake()
    {
        Vector3 xyz = new Vector3(0, 0, 0);

        if (scene == 1)
        {
            int i = Random.Range(0, 3);
            if (i == 0)
            {
                xyz.Set(-10, 0, 10);
            }
            else if (i == 2)
            {
                xyz.Set(10, 0, 0);
            }
        }
        else if (scene == 2)
        {
            xyz.Set(0, 1.25f, 0);
        }
        transform.position = xyz;

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
