using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    Ps4Controller movePlayer;
    public CharacterController player;
    Vector2 move;
    public Light cLight;
    public Light pLight;
    public Light lantern;

    void Awake()
    {
        movePlayer = new Ps4Controller();

        movePlayer.Player.MovePlayer.performed += ctx => move=ctx.ReadValue<Vector2>();
        movePlayer.Player.MovePlayer.canceled +=ctx=>move=Vector2.zero;

        movePlayer.Player.LightsOn.performed += ctx => closeTheLight();

        movePlayer.Player.LanternOn.performed += ctx => closeTheLantern();
    }
    void OnEnable()
    {
        movePlayer.Player.Enable();
    }
    void OnDisable()
    {
        movePlayer.Player.Disable();
    }
    void closeTheLight()
    {
        if (cLight.enabled)
        {
            cLight.enabled = false;
            pLight.enabled = false;
        }
        else
        {
            cLight.enabled = true;
            pLight.enabled = true;
        }
    }
    void closeTheLantern()
    {
        if (lantern.enabled==false)
        {
            lantern.enabled = true;
        }
        else
        {
            lantern.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 m = transform.right * move.x + transform.forward * move.y;
        player.Move(m*0.1f);
    }
}
