using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeOneScript : MonoBehaviour
{
    public static bool on = false;
    public GameObject cubeSmall;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!on)
            {
                cubeSmall.SetActive(false);
                on = !on;
            }
            else
            {
                cubeSmall.SetActive(true);
                on = !on;
            }
        }
    }
}
