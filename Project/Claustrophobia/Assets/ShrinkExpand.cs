using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkExpand : MonoBehaviour
{
    Ps4Controller ShrinkOrExanpand;
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;
    public GameObject ceiling;
    int ShrinkOrExpandRate = 2;
    int moveRate = 1;
    void Awake()
    {
        ShrinkOrExanpand = new Ps4Controller();
        ShrinkOrExanpand.Player.Shrink.performed += ctx => Shrink();
        ShrinkOrExanpand.Player.Expand.performed += ctx => Expand();
    }
    void OnEnable()
    {
        ShrinkOrExanpand.Player.Enable();
    }
    void OnDisable()
    {
        ShrinkOrExanpand.Player.Disable();
    }
    void Shrink()
    {
        //don't shrink to much
        if(wall1.transform.localScale.z!=4f)
        {
            ShrinkWall(wall1);
            Wall1MoveFront();
            ShrinkWall(wall2);
            Wall2MoveFront();
            ShrinkWall(wall3);
            Wall3MoveFront();
            ShrinkWall(wall4);
            Wall4MoveFront();
        }
        
    }
    void Expand()
    {
        //don't expand to much
        if (wall1.transform.localScale.z != 100f)
        {
            ExpandWall(wall1);
            Wall1MoveBack();
            ExpandWall(wall2);
            Wall2MoveBack();
            ExpandWall(wall3);
            Wall3MoveBack();
            ExpandWall(wall4);
            Wall4MoveBack();
        }
            
    }
    void ShrinkWall(GameObject wall)
    {
        Vector3 scale = wall.transform.localScale;
        scale.z -= ShrinkOrExpandRate;
        wall.transform.localScale = scale;
    }
    void ExpandWall(GameObject wall)
    {
        Vector3 scale = wall.transform.localScale;
        scale.z += ShrinkOrExpandRate;
        wall.transform.localScale = scale;
    }
    void Wall1MoveFront()
    {
        Vector3 move = wall1.transform.localPosition;
        if(move.z<23)
        {
            move.z += moveRate;
            wall1.transform.localPosition = move;
        }
        
    }
    void Wall1MoveBack()
    {
        Vector3 move = wall1.transform.localPosition;
        move.z -= moveRate;
        wall1.transform.localPosition = move;
    }
    void Wall2MoveFront()
    {
        Vector3 move = wall2.transform.localPosition;
        if (move.x > -18)
        {
            move.x -= moveRate;
            wall2.transform.localPosition = move;
        }
            
    }
    void Wall2MoveBack()
    {
        Vector3 move = wall2.transform.localPosition;
        move.x += moveRate;
        wall2.transform.localPosition = move;
    }
    void Wall3MoveFront()
    {
        Vector3 move = wall3.transform.localPosition;
        if (move.z > 26)
        {
            move.z -= moveRate;
            wall3.transform.localPosition = move;
        }
        
    }
    void Wall3MoveBack()
    {
        Vector3 move = wall3.transform.localPosition;
        move.z += moveRate;
        wall3.transform.localPosition = move;
    }
    void Wall4MoveFront()
    {
        Vector3 move = wall4.transform.localPosition;
       if (move.x < -21)
        {
            move.x += moveRate;
            wall4.transform.localPosition = move;
        }
            
    }
    void Wall4MoveBack()
    {
        Vector3 move = wall4.transform.localPosition;
        move.x -= moveRate;
        wall4.transform.localPosition = move;
    }
}
