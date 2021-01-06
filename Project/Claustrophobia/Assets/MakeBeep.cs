using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBeep : MonoBehaviour
{
    // Start is called before the first frame update
    public CharacterController player;
    public GameObject wall1;
    public AudioSource beep;
    Ps4Controller makeBeep;
    float distance;
    bool isOn = false;
    void Awake()
    {
        makeBeep = new Ps4Controller();
        makeBeep.Player.Beep.performed += ctx => TurnOn();
    }
    void OnEnable()
    {
        makeBeep.Player.Enable();
    }
    void OnDisable()
    {
        makeBeep.Player.Disable();
    }
    void Start()
    {
        distance = Vector3.Distance(wall1.transform.localPosition, player.transform.position);
        beep.pitch = 1f + distance / 50;
    }
    void TurnOn()
    {
        if (isOn == false)
        {
            beep.loop = true;
            beep.playOnAwake = true;
            isOn = true;
            beep.Play();
        }
        else
        {
            beep.loop = false;
            beep.playOnAwake = false;
            isOn = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
