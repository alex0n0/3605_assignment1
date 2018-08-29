using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeThreeScript : MonoBehaviour
{
    public static bool on = false;
    public GameObject cubeSmall;
    Material mMaterial;

    void Start()
    {
        mMaterial = GetComponent<Renderer>().material;
        mMaterial.color = Color.green;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(cubeSmall, new Vector3(0, 14, 10), Quaternion.identity);
        }
    }
}
