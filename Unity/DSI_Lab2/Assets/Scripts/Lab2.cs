using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab2 : MonoBehaviour
{
    private void OnEnable()
    {
        UIDocument uiDoc = GetComponent<UIDocument>();  
        VisualElement rootVe = uiDoc.rootVisualElement;

        UQueryBuilder<VisualElement> builder = new(rootVe);

        //List<VisualElement> lista_ve = builder.ToList();
        //VisualElement contenedor = builder.Name("Body");

        //List<VisualElement> lista_ve2 = contenedor.Children().ToList();
        //List<VisualElement> lista_ve3 = rootVe.Query().ToList();
        List<VisualElement> lista_ve4 = rootVe.Query(className: "Icon").ToList();

        //Cambiar el numero de la lista según lo que probemos de arriba
        lista_ve4.ForEach(e =>
        {
            Debug.Log(e.name);
            e.style.backgroundColor = Color.white;
        });

        List<VisualElement> lista_ve5 = rootVe.Query(className: "Selector").ToList();
        lista_ve5.ForEach(e =>
        {
            Debug.Log(e.name);
            e.style.flexDirection = FlexDirection.ColumnReverse;
            
            
        });

        ////Esto
        //VisualElement ve = rootVe.Query(className: "Selector").First();
        //Debug.Log(ve.name);

        ////Equivale a esto
        //VisualElement ve = rootVe.Q(className: "Selector");
        //Debug.Log(ve.name);

    }


}
