using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScene1 : MonoBehaviour
{
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            int i = Random.Range(0, 3);
            Vector3 xyz = new Vector3(0, 0, 0);
            if (i == 0)
            {
                xyz.Set(-10, 0, 10);
            }
            else if (i == 2)
            {
                xyz.Set(10, 0, 0);
            }
            player.transform.position = xyz;
            player.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
