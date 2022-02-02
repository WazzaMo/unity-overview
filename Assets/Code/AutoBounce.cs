using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBounce : MonoBehaviour
{
    const float BASE = 0.5f;

    private Transform _Transform;
    private Rigidbody _Rigidbody;

    [Header("Forward m/s")]
    public float speed = 10.0f;

    [Header("Vert Rotate deg/s")]
    public float AngularForce = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        _Transform = GetComponent<Transform>();
        _Rigidbody = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        float forwardSpeed = Time.deltaTime * speed * Input.GetAxis("Vertical");
        float yForce = Time.deltaTime * AngularForce * Input.GetAxis("Horizontal");

        Quaternion rotation = _Transform.rotation;
        Vector3 forward = rotation * Vector3.forward;
        _Rigidbody.AddForce(forward * forwardSpeed);

        _Rigidbody.AddTorque(0, yForce, 0);
    }
}
