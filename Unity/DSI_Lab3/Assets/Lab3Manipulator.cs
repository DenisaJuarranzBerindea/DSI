using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab3Manipulator : MouseManipulator
{
    protected bool m_Active;

    public Lab3Manipulator()
    {
        activators.Add(new ManipulatorActivationFilter { button = MouseButton.RightMouse });
    }

    protected override void RegisterCallbacksOnTarget()
    {
        target.RegisterCallback<MouseMoveEvent>(OnMouseMove);
        target.RegisterCallback<MouseLeaveEvent>(OnMouseLeave);
    }

    protected override void UnregisterCallbacksFromTarget()
    {
        target.UnregisterCallback<MouseMoveEvent>(OnMouseMove);
        target.UnregisterCallback<MouseLeaveEvent>(OnMouseLeave);
    }

    private void OnMouseMove(MouseMoveEvent mouseEvent)
    {
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

    private void OnMouseLeave(MouseLeaveEvent mouseEvent)
    {
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
