using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Lab3 : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        //Chars
        VisualElement OptionMario = root.Q("Mario");
        VisualElement OptionLuigi = root.Q("Luigi");
        VisualElement OptionPeach = root.Q("Peach");
        VisualElement OptionEstela = root.Q("Estela");

        //Vehicles
        VisualElement OptionNKart = root.Q("NormalKart");
        VisualElement OptionSKart = root.Q("SpecialKart");
        VisualElement OptionNBike = root.Q("NormalBike");
        VisualElement OptionSBike = root.Q("SpecialBike");

        //Selection
        OptionMario.AddManipulator(new Lab3Manipulator());
        OptionLuigi.AddManipulator(new Lab3Manipulator());
        OptionPeach.AddManipulator(new Lab3Manipulator());
        OptionEstela.AddManipulator(new Lab3Manipulator());

        OptionNKart.AddManipulator(new Lab3Manipulator());
        OptionSKart.AddManipulator(new Lab3Manipulator());
        OptionNBike.AddManipulator(new Lab3Manipulator());
        OptionSBike.AddManipulator(new Lab3Manipulator());

        //Resize
        OptionMario.AddManipulator(new Lab3Resizer());
        OptionLuigi.AddManipulator(new Lab3Resizer());
        OptionPeach.AddManipulator(new Lab3Resizer());
        OptionEstela.AddManipulator(new Lab3Resizer());

        OptionNKart.AddManipulator(new Lab3Resizer());
        OptionSKart.AddManipulator(new Lab3Resizer());
        OptionNBike.AddManipulator(new Lab3Resizer());
        OptionSBike.AddManipulator(new Lab3Resizer());

    }
}
