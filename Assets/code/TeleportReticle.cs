using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportReticle : MonoBehaviour
{
 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,3,0,Space.World);
    }
}
