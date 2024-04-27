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

        //OptionMario.RegisterCallback<MouseDownEvent>
        //(
        //    ev =>
        //    {
        //        Debug.Log("Mario. Fase: " + ev.propagationPhase);
        //        Debug.Log("Mario. Current target: " + (ev.currentTarget as VisualElement).name);
        //        Debug.Log("Mario. Target: " + (ev.target as VisualElement).name);
        //    }
        //);
        //OptionLuigi.RegisterCallback<MouseDownEvent>
        //(
        //    ev =>
        //    {
        //        Debug.Log("Luigi. Fase: " + ev.propagationPhase);
        //        Debug.Log("Luigi. Current target: " + (ev.currentTarget as VisualElement).name);
        //        Debug.Log("Luigi. Target: " + (ev.target as VisualElement).name);
        //    }
        //);
        //OptionPeach.RegisterCallback<MouseDownEvent>
        //(
        //    ev =>
        //    {
        //        Debug.Log("Peach. Fase: " + ev.propagationPhase);
        //        Debug.Log("Peach. Current target: " + (ev.currentTarget as VisualElement).name);
        //        Debug.Log("Peach. Target: " + (ev.target as VisualElement).name);
        //    }
        //);
        //OptionEstela.RegisterCallback<MouseDownEvent>
        //(
        //    ev =>
        //    {
        //        Debug.Log("Estela. Fase: " + ev.propagationPhase);
        //        Debug.Log("Estela. Current target: " + (ev.currentTarget as VisualElement).name);
        //        Debug.Log("Estela. Target: " + (ev.target as VisualElement).name);
        //    }
        //);

        //Vehicles
        VisualElement OptionNKart = root.Q("NormalKart");
        VisualElement OptionSKart = root.Q("SpecialKart");
        VisualElement OptionNBike = root.Q("NormalBike");
        VisualElement OptionSBike = root.Q("SpecialBike");

        //OptionNKart.RegisterCallback<MouseDownEvent>
        //(
        //    ev =>
        //    {
        //        Debug.Log("Normal Kart. Fase: " + ev.propagationPhase);
        //        Debug.Log("Normal Kart. Current target: " + (ev.currentTarget as VisualElement).name);
        //        Debug.Log("Normal Kart. Target: " + (ev.target as VisualElement).name);
        //    }
        //);
        //OptionSKart.RegisterCallback<MouseDownEvent>
        //(
        //    ev =>
        //    {
        //        Debug.Log("Special Kart. Fase: " + ev.propagationPhase);
        //        Debug.Log("Special Kart. Current target: " + (ev.currentTarget as VisualElement).name);
        //        Debug.Log("Special Kart. Target: " + (ev.target as VisualElement).name);
        //    }
        //);
        //OptionNBike.RegisterCallback<MouseDownEvent>
        //(
        //    ev =>
        //    {
        //        Debug.Log("Normal Bike. Fase: " + ev.propagationPhase);
        //        Debug.Log("Normal Bike. Current target: " + (ev.currentTarget as VisualElement).name);
        //        Debug.Log("Normal Bike. Target: " + (ev.target as VisualElement).name);
        //    }
        //);
        //OptionSBike.RegisterCallback<MouseDownEvent>
        //(
        //    ev =>
        //    {
        //        Debug.Log("Special Bike. Fase: " + ev.propagationPhase);
        //        Debug.Log("Special Bike. Current target: " + (ev.currentTarget as VisualElement).name);
        //        Debug.Log("Special Bike. Target: " + (ev.target as VisualElement).name);
        //    }
        //);

        OptionMario.AddManipulator(new Lab3Manipulator());
        OptionLuigi.AddManipulator(new Lab3Manipulator());
        OptionPeach.AddManipulator(new Lab3Manipulator());
        OptionEstela.AddManipulator(new Lab3Manipulator());

        OptionNKart.AddManipulator(new Lab3Manipulator());
        OptionSKart.AddManipulator(new Lab3Manipulator());
        OptionNBike.AddManipulator(new Lab3Manipulator());
        OptionSBike.AddManipulator(new Lab3Manipulator());

        ////Otra forma más efectiva sería
        //List<VisualElement> lista_ve4 = root.Query(className: "OptionBg").ToList();

        ////Cambiar el numero de la lista según lo que probemos de arriba
        //lista_ve4.ForEach(e =>
        //{
        //    e.RegisterCallback<MouseDownEvent>
        //    (
        //        ev =>
        //        {
        //            (ev.target as VisualElement).style.borderLeftWidth = 2;
        //            (ev.target as VisualElement).style.borderBottomWidth = 2;
        //            (ev.target as VisualElement).style.borderRightWidth = 2;
        //            (ev.target as VisualElement).style.borderTopWidth = 2;

        //            (ev.target as VisualElement).style.borderLeftColor = Color.white;
        //            (ev.target as VisualElement).style.borderBottomColor = Color.white;
        //            (ev.target as VisualElement).style.borderRightColor = Color.white;
        //            (ev.target as VisualElement).style.borderTopColor = Color.white;
        //        }
        //    );
        //});
    }
}
