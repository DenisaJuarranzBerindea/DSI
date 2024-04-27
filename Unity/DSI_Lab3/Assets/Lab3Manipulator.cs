using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab3Manipulator : MouseManipulator
{
    public Lab3Manipulator()
    {
        activators.Add(new ManipulatorActivationFilter { button = MouseButton.RightMouse });
    }

    protected override void RegisterCallbacksOnTarget()
    {
        target.RegisterCallback<MouseDownEvent>(OnMouseDown);
    }

    protected override void UnregisterCallbacksFromTarget()
    {
        target.UnregisterCallback<MouseDownEvent>(OnMouseDown);
    }

    private void OnMouseDown(MouseDownEvent mouseEvent)
    {
        Debug.Log(target.name + ": Click en Elemento");

        if (mouseEvent != null)
        {
            target.style.borderLeftWidth = 2;
            target.style.borderBottomWidth = 2;
            target.style.borderRightWidth = 2;
            target.style.borderTopWidth = 2;

            target.style.borderLeftColor = Color.white;
            target.style.borderBottomColor = Color.white;
            target.style.borderRightColor = Color.white;
            target.style.borderTopColor = Color.white;
            mouseEvent.StopImmediatePropagation();
        }
    }

    private void OnMouseUp(MouseUpEvent mouseEvent)
    {
        Debug.Log(target.name + ": No click en Elemento");

        if (mouseEvent != null)
        {
            target.style.borderLeftWidth = 0;
            target.style.borderBottomWidth = 0;
            target.style.borderRightWidth = 0;
            target.style.borderTopWidth = 0;

            mouseEvent.StopImmediatePropagation();
        }
    }
}
