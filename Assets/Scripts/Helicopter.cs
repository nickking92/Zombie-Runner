﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {
    private bool called = false;
    private Rigidbody rigidBody;
    // public AudioClip callSound;
    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
    }

    void OnDispatchHelicopter()
    {
        Debug.Log("Helicopter called");
        rigidBody.velocity = new Vector3(0, 0, 50f);
        called = true;
    }
}
