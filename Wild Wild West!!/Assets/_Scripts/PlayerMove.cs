using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 10;
    public bool onGround;
    private Rigidbody rb;
    public Vector2 mouseTurn;
    public float sensitivity = .5f;
    void Start()
    {
        //For jumping
        onGround = true;
        rb = GetComponent<Rigidbody>();

        //Mouse move
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        //Moves front and back
        float xAxis = Input.GetAxis("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        //For jumping
        if (onGround)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector3(0, 5f, 0f);
                onGround = false;
            }
        }
        Vector3 pos = transform.position;
        pos.x += xAxis * speed * Time.deltaTime;
        pos.z += zAxis * speed * Time.deltaTime;

        transform.position = pos;


        //For mouse movement

        mouseTurn.x += Input.GetAxis("Mouse X") * sensitivity;
        mouseTurn.y += Input.GetAxis("Mouse Y") * sensitivity;
        transform.localRotation = Quaternion.Euler(0, mouseTurn.x, 0);
    }

    //For jumping
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.CompareTag("Ground");
        onGround = true;
    }
}
