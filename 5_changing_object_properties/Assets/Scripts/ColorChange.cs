using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
    public static bool on = false;
    Material mMaterial;
    void Start()
    {
        mMaterial = GetComponent<Renderer>().material;
    }
    void OnTriggerEnter (Collider other) {
        if (other.CompareTag("Player"))
        {
            if (!on)
            {
                mMaterial.color = Color.green;
                on = !on;
            }
            else
            {
                mMaterial.color = Color.red;
                on = !on;
            }
        }
    }
}
