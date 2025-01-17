using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment37
{
    public class RigidbodyCharacterController : MonoBehaviour
    {
        new Rigidbody rigidbody;
        Vector3 input;
        bool jump = false;
        float speed = 4f;
        void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
            rigidbody.freezeRotation = true;
            rigidbody.mass = 1f;
        }

        void Update()
        {
            input = new Vector3(-Input.GetAxisRaw("Horizontal"), 0, -Input.GetAxisRaw("Vertical"));
            input = input.normalized * speed;
            input.y = rigidbody.velocity.y;
            if (Input.GetKeyUp(KeyCode.Space))
            {
                jump = true;
            }
        }

        void FixedUpdate()
        {
            if (jump)
            {
                rigidbody.drag = 0.5f;
                rigidbody.AddForce(Vector3.up * 50, ForceMode.Impulse);
                jump = false;
            }
            else
            {
                rigidbody.drag = 0;
                rigidbody.velocity = input;
            }
        }
    }
}