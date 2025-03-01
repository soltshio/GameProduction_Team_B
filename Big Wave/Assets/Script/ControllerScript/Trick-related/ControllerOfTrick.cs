using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

//作成者:杉山
//トリックの操作
public class ControllerOfTrick : MonoBehaviour
{
    Trick trick;

    void Start()
    {
        trick = GameObject.FindWithTag("Player").GetComponentInChildren<Trick>();
    }

    public void Trick_North(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        trick.TrickTrigger(TrickButton.north);//トリック
    }

    public void Trick_West(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        trick.TrickTrigger(TrickButton.west);//トリック
    }

    public void Trick_East(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        trick.TrickTrigger(TrickButton.east);//トリック
    }

    public void Trick_South(InputAction.CallbackContext context)
    {
        if (!context.performed) return;
        trick.TrickTrigger(TrickButton.south);//トリック
    }
}
