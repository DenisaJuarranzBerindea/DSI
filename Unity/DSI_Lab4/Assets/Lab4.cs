using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab4 : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Label Mario = root.Q<Label>("NameMario");
        Mario.text = @"<gradient=""Mario""><i> MARIO </i></gradient>";
        



    }




}
