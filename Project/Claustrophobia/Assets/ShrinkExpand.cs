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

        ShrinkOrExanpand.Player.Reset.performed += ctx => ResetRoom();
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
            ShrinkCeilling();
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
            ExpandCeilling();
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
        move.z += moveRate;
        wall1.transform.localPosition = move;     
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
        move.x -= moveRate;
        wall2.transform.localPosition = move;     
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
        move.z -= moveRate;
        wall3.transform.localPosition = move;      
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
        move.x += moveRate;
        wall4.transform.localPosition = move;          
    }
    void Wall4MoveBack()
    {
        Vector3 move = wall4.transform.localPosition;
        move.x -= moveRate;
        wall4.transform.localPosition = move;
    }
    void ShrinkCeilling()
    {
        Vector3 scale = ceiling.transform.localScale;
        scale.z -= ShrinkOrExpandRate;
        scale.x -= ShrinkOrExpandRate;
        ceiling.transform.localScale = scale;

        Vector3 move = ceiling.transform.localPosition;
        move.y -= 0.1f;
        ceiling.transform.localPosition = move;
    }
    void ExpandCeilling()
    {
        Vector3 scale = ceiling.transform.localScale;
        scale.z += ShrinkOrExpandRate;
        scale.x += ShrinkOrExpandRate;
        ceiling.transform.localScale = scale;

        Vector3 move = ceiling.transform.localPosition;
        move.y += 0.1f;
        ceiling.transform.localPosition = move;
    }
    void ResetRoom()
    {
        Vector3 resetWall1 = wall1.transform.localPosition;
        resetWall1.x= -20.5f;
        resetWall1.y = 7.5f;
        resetWall1.z = -25f;
        wall1.transform.localPosition = resetWall1;
        resetWallSize(wall1);

        Vector3 resetWall2 = wall2.transform.localPosition;
        resetWall2.x = 30f;
        resetWall2.y = 7.5f;
        resetWall2.z = 25f;
        wall2.transform.localPosition = resetWall2;
        resetWallSize(wall2);

        Vector3 resetWall3 = wall3.transform.localPosition;
        resetWall3.x = -20.5f;
        resetWall3.y = 7.5f;
        resetWall3.z = 75f;
        wall3.transform.localPosition = resetWall3;
        resetWallSize(wall3);

        Vector3 resetWall4 = wall4.transform.localPosition;
        resetWall4.x = -70f;
        resetWall4.y = 7.5f;
        resetWall4.z = 25f;
        wall4.transform.localPosition = resetWall4;
        resetWallSize(wall4);

        Vector3 resetCeillingScale = ceiling.transform.localScale;
        resetCeillingScale.x = 100f;
        resetCeillingScale.y = 1f;
        resetCeillingScale.z = 100f;
        ceiling.transform.localScale = resetCeillingScale;

        Vector3 resetCeillingPosition = ceiling.transform.localPosition;
        resetCeillingPosition.x = -20f;
        resetCeillingPosition.y = 15f;
        resetCeillingPosition.z = 25f;
        ceiling.transform.localPosition = resetCeillingPosition;
    }
    void resetWallSize(GameObject wall)
    {
        Vector3 resetWall = wall.transform.localScale;
        resetWall.x = 1f;
        resetWall.y = 15f;
        resetWall.z = 100f;
        wall.transform.localScale = resetWall;
    }
}
