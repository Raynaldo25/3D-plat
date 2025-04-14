using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rb;
    Vector3 myLook;

    public float speed = 2f;
    public float lookSpeed = 5f;
    public float jumpForce = 6f;
    public float liftForce = 12f;
    public int score = 0;

    public Boolean onFloor;
    public bool onTarget;

    public GameObject myCam;
    public float camLock = 90;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        myLook = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerLook = myCam.transform.TransformDirection(Vector3.forward);
        myLook += DeltaLook() * Time.deltaTime;

        if (myLook.y > camLock)
        {
            myLook.y = camLock;
        }
        else if (myLook.y < -camLock)
        {
            myLook.y = -camLock;
        }

        transform.rotation = Quaternion.Euler(0f, myLook.x, 0f);
        myCam.transform.rotation = Quaternion.Euler(-myLook.y, myLook.x, 0f);

      /*  if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * speed);
        }*/
        if (Input.GetKey(KeyCode.Space) && onFloor == true)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }

    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground") { onFloor = true; }
        if (collision.gameObject.tag == "Tar") 
        {
            onFloor = true;
            onTarget = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        onFloor = false;
        onTarget = false;
    }

    private void FixedUpdate()
    {
        Vector3 myDir = transform.TransformDirection(Dir());
        rb.AddForce(myDir * speed);
    }

    Vector3 Dir()
    {
        Vector3 moveDir = Vector3.zero;
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        moveDir = new Vector3(x, 0, z);
        return moveDir;
    }
    Vector3 DeltaLook()
    {
        Vector3 deltaLook = Vector3.zero;
        float rotY = Input.GetAxisRaw("Mouse Y") * lookSpeed;
        float rotX = Input.GetAxisRaw("Mouse X") * lookSpeed;

        //combining them here
        deltaLook = new Vector3(rotX, rotY, 0);
        return deltaLook;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "chest")
        {
            score++;
            GameManager.Instance.Score++;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "lava")
        {
            
            Destroy(gameObject);
            SceneManager.LoadScene("end");
        }
        if(collision.gameObject.tag == "lift")
        {
            
            rb.AddForce(Vector3.up * liftForce);
            
        }
    }
}
