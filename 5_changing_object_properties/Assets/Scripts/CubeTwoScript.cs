using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTwoScript : MonoBehaviour
{
    public static bool on = false;
    public GameObject cubeSmall;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!on)
            {
                cubeSmall.transform.position = new Vector3(0, 5, 8);
                cubeSmall.transform.localScale += new Vector3(3f, 3f, 3f);
                on = !on;
            }
            else
            {
                cubeSmall.transform.position = new Vector3(0, 2.5f, 10);
                cubeSmall.transform.localScale -= new Vector3(3f, 3f, 3f);
                on = !on;
            }
        }
    }
}
