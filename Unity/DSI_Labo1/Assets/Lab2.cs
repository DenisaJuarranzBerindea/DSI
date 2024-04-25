using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UIElements;

public class Lab2 : MonoBehaviour
{
    private void OnEnable()
    { 
        UIDocument uiDoc = GetComponent<UIDocument>();
        VisualElement rootve = uiDoc.rootVisualElement;

        //Creamos una lista con los objetos de los dos selectores
        VisualElement characters = rootve.Query("LeftSelector");
        VisualElement weapons = rootve.Query("RightSelector");
        List<VisualElement> lista_ve = new List<VisualElement>();

        lista_ve.AddRange(characters.Children().ToList());
        lista_ve.AddRange(weapons.Children().ToList());

        //Leemos su nombre y cambiamos el color del fondo a blanco
        lista_ve.ForEach(elem =>
        {
            Debug.Log(elem.name);
            elem.style.backgroundColor = Color.white;
        });

        //Y revertimos sus elementos de posición
        characters.style.flexDirection = FlexDirection.ColumnReverse;
        weapons.style.flexDirection = FlexDirection.ColumnReverse;

    }
}
