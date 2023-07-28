using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float thrustPower = 20f;
    [SerializeField] private float rotationSpeed = 10f;


    private Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessRotation();
    }

    private void FixedUpdate()
    {
        ProcessThrust();
    }

    private void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            // THRUST
            myRigidbody.AddRelativeForce(Vector3.up * (thrustPower * 100 * Time.deltaTime));
        }
    }

    private void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            // ROTATE LEFT
            ApplyRotation(1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // ROTATE RIGHT
            ApplyRotation(-1);

        }
    }

    private void ApplyRotation(int r)
    {
        myRigidbody.freezeRotation = true;
        transform.Rotate(Vector3.forward * (r * rotationSpeed * Time.deltaTime));

        myRigidbody.freezeRotation = false;
    }
}