using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScene2 : MonoBehaviour {

    public GameObject player;
    public Vector3 xyz;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = xyz;
            player.transform.eulerAngles = new Vector3(0, 0, 0);
        }

    }
}
