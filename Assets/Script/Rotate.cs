using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Speed of rotation (can be set in the Inspector)
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotate the object around its local Y-axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
