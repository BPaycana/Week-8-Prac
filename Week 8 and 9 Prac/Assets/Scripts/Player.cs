using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float thrustSpeed = 1.0f;
    public float strafeSpeed = 1.0f;
    private bool _thrusting;
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        float horizontal = Input.GetAxis("Horizontal");
    float vertical = Input.GetAxis("Vertical");
    float speed = 5.0f;
    }

    

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _thrusting = true;
            thrustSpeed = 10.0f;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _thrusting = true;
            thrustSpeed = -10.0f;
        }
        else
        {
            thrustSpeed = 0.0f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            strafeSpeed = -10.0f;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            strafeSpeed = 10.0f;
        }
        else
        {
            strafeSpeed = 0.0f;
        }
    }

    private void FixedUpdate()
    {
        if (thrustSpeed != 0)
        {
            transform.position += (Vector3.forward * Time.deltaTime) * thrustSpeed;
            //_rigidbody.AddForce(this.transform.up * thrustSpeed);
        }
        if (strafeSpeed != 0)
        {
            transform.position += (Vector3.right * Time.deltaTime) * strafeSpeed;
        }

    }
}
