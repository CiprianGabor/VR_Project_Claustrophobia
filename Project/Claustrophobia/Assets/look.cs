using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{
    public Transform player;
    Ps4Controller lookTo;
    Vector2 rotate;
    float xRotation = 0f;
    // Start is called before the first frame update
    void Awake()
    {
        lookTo = new Ps4Controller();

        lookTo.Player.RotatePlayer.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        lookTo.Player.RotatePlayer.canceled += ctx => rotate = Vector2.zero;
    }
    void Start()
    {/*
        Cursor.lockState = CursorLockMode.Locked;*/
    }
    void OnEnable()
    {
        lookTo.Player.Enable();
    }
    void OnDisable()
    {
        lookTo.Player.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        xRotation -= rotate.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation,0f, 0f);
        player.Rotate(Vector3.up * rotate.x);
    }
}
