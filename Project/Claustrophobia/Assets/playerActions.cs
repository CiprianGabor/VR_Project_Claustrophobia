using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class playerActions : MonoBehaviour
{
    // Start is called before the first frame update
    Ps4Controller movePlayer;
    public CharacterController player;
    Vector2 move;
    public Light cLight;
    public Light lantern;
    bool escape = false;

    void Awake()
    {
        movePlayer = new Ps4Controller();
        movePlayer.Player.MovePlayer.performed += ctx => move=ctx.ReadValue<Vector2>();
        movePlayer.Player.MovePlayer.canceled +=ctx=>move=Vector2.zero;

        movePlayer.Player.LightsOn.performed += ctx => closeTheLight();
        movePlayer.Player.LanternOn.performed += ctx => closeTheLantern();
        movePlayer.Player.Escape.performed += ctx => Escape();
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
            cLight.enabled = false;
        else
            cLight.enabled = true;
    }
    void closeTheLantern()
    {
        if (lantern.enabled==false)
            lantern.enabled = true;
        else
            lantern.enabled = false;
    }
    void Escape()
    {
        if(escape==false)
        {
            Vector3 move = player.transform.localPosition;
            move.x = 1500f;
            move.y = 1f;
            move.z = 100f;
            player.enabled = false;
            player.transform.localPosition = move;
            player.enabled = true;
            escape = true;
        }
        else
        {
            Vector3 move = player.transform.localPosition;
            move.x = -19.5f;
            move.y = 2.58f;
            move.z = 24.5f;
            player.enabled = false;
            player.transform.localPosition = move;
            player.enabled = true;
            escape = false;
        }
        
    }

    void Update()
    {
        Vector3 m = transform.right * move.x + transform.forward * move.y;
        player.Move(m*0.1f);
    }
}
