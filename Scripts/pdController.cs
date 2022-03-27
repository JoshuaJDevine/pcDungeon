using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pdController : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode rightKey;
    public KeyCode leftKey;

    private void Update()
    {
        if (Input.GetKeyDown(upKey))
        {
            if (!IsWall())
            {
                Debug.Log("Not wall");
            }
        }
    }


    public bool IsWall()
    {
        // Bit shift the index of the layer (8) to get a bit mask
        int layerMask = 1 << 8;

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Did Hit 8");
            return true;
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit 8");
            return false;
        }
    }
    
    
}
