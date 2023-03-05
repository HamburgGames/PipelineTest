using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Rotator : MonoBehaviour {

    [SerializeField] private Transform transform;
    [SerializeField] private float3 eulerRotation = new float3(0, 1, 0);
    [SerializeField] private float rotationSpeed = 1;

    private void FixedUpdate() {
	    var rotQ = Quaternion.AngleAxis(Time.deltaTime * rotationSpeed, eulerRotation);
	    transform.localRotation = rotQ * transform.localRotation;
    }

    private void OnGUI() {
	    Debug.DrawLine(transform.position + Vector3.down * 2, transform.position + Vector3.up * 2, Color.red);
    }
}
