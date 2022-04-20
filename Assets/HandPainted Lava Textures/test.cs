using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public bool isGrounded;
    void Start()
    {

    }

    void OnCollisionStay()
    {
        Debug.Log("Değdi");
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.forward);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.back);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded){
            rb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
