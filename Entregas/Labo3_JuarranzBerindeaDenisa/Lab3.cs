using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UIElements;

public class Lab3 : MonoBehaviour
{
    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Button char1 = root.Query<Button>("Char1");
        Button char2 = root.Query<Button>("Char2");
        Button weapon1 = root.Query<Button>("Weapon1");
        Button weapon2 = root.Query<Button>("Weapon2");

        char1.RegisterCallback<MouseDownEvent>(
            ev =>
            {
                Debug.Log("Char 1. Fase: " + ev.propagationPhase);
                Debug.Log("Char 1. Current Target: " + (ev.currentTarget as VisualElement).name);
                Debug.Log("Char 1. Target: " + (ev.target as VisualElement).name);
            }, TrickleDown.TrickleDown);
        char2.RegisterCallback<MouseDownEvent>(
            ev =>
            {
                Debug.Log("Char 2. Fase: " + ev.propagationPhase);
                Debug.Log("Char 2. Current Target: " + (ev.currentTarget as VisualElement).name);
                Debug.Log("Char 2. Target: " + (ev.target as VisualElement).name);
            }, TrickleDown.NoTrickleDown);
        weapon1.RegisterCallback<MouseDownEvent>(
            ev =>
            {
                Debug.Log("Weapon 1. Fase: " + ev.propagationPhase);
                Debug.Log("Weapon 1. Current Target: " + (ev.currentTarget as VisualElement).name);
                Debug.Log("Weapon 1. Target: " + (ev.target as VisualElement).name);
            }, TrickleDown.TrickleDown);
        weapon2.RegisterCallback<MouseDownEvent>(
            ev =>
            {
                Debug.Log("Weapon 2. Fase: " + ev.propagationPhase);
                Debug.Log("Weapon 2. Current Target: " + (ev.currentTarget as VisualElement).name);
                Debug.Log("Weapon 2. Target: " + (ev.target as VisualElement).name);
            }, TrickleDown.NoTrickleDown);
    }

}
