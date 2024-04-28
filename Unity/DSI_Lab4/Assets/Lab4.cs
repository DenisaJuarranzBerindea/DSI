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

        Label Luigi = root.Q<Label>("NameLuigi");
        Luigi.text = @"<gradient=""Luigi""><i> LUIGI </i></gradient>";

        Label Peach = root.Q<Label>("NamePeach");
        Peach.text = @"<gradient=""Peach""><i> PEACH </i></gradient>";

        Label Estela = root.Q<Label>("NameEstela");
        Estela.text = @"<gradient=""Estela""><i> ESTELA </i></gradient>";

        Label SKart = root.Q<Label>("NameSKart");
        SKart.text = @"<gradient=""Special""><i> SPECIAL KART </i></gradient>";

        Label SBike = root.Q<Label>("NameSBike");
        SBike.text = @"<gradient=""Special""><i> SPECIAL BIKE </i></gradient>";

    }




}
