﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset;

    private void Start()
    {
        offset = transform.position - player.transform.position;
    }

    private void LateUpdate()
    {
        if (player == null)
        {
            gameObject.GetComponent<CameraFollow>().enabled = false;
            return;
        }
        transform.position = player.transform.position + offset;
    }
}