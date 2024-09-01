// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SpinPropeller.cs">
//   Copyright (c) 2023 Y0RED. All rights reserved.
// </copyright>
// <author>
//   Y0RED
//   https://github.com/Y0red
// </author>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
   [SerializeField] float rotationSpeed = 1000f;

    void Update() => transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    
}
