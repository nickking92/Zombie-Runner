using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCircle : MonoBehaviour {
    [Tooltip("Number of minutes per second")]
    public float minutesPerSecond;
    private Quaternion startRotations;
	void Start () {
        startRotations = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
        float angleThisFrame = Time.deltaTime / 360 *minutesPerSecond;
        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame);
	}
}
