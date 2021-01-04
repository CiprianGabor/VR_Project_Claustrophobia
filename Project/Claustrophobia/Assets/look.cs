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
        lookTo.LookTo.lookAt.performed += ctx => rotate = ctx.ReadValue<Vector2>();
        lookTo.LookTo.lookAt.canceled += ctx => rotate = Vector2.zero;
    }
    void OnEnable()
    {
        lookTo.LookTo.Enable();
    }
    void OnDisable()
    {
        lookTo.LookTo.Disable();
    }

    void Update()
    {
        xRotation -= rotate.y;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation,0f, 0f);
        player.Rotate(Vector3.up * rotate.x);
    }
}
