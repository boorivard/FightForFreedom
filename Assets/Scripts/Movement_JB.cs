using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_JB : MonoBehaviour
{
    public float speed = 5.0f; // Speed of player movementprivate Vector3 previousPosition;

    void Update()
    {
        // Move player based on input from W, A, S, and D keys
        float horizontalInput = 0.0f;
        float verticalInput = 0.0f;

        if (Input.GetKey(KeyCode.A))
        {
            horizontalInput = -1.0f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            horizontalInput = 1.0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            verticalInput = 1.0f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            verticalInput = -1.0f;
        }

        transform.Translate(new Vector3(horizontalInput, 0.0f, verticalInput) * speed * Time.deltaTime);
    }
}