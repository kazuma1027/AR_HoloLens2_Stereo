﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class D_Down : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _drone;
    // var cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
    public void OnClick(){
        // var cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
        // Vector3 direction = cameraForward * -0.1f + Camera.main.transform.right * 0;
        // build.transform.position += direction;
        _drone.transform.position += new Vector3(0, -0.025f, 0);
    }
}
