using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab4B : VisualElement
{
    VisualElement star1 = new VisualElement();
    VisualElement star2 = new VisualElement();  
    VisualElement star3 = new VisualElement();

    int starsActive = 0;

    public int Estado
    {
        get => starsActive;
        set
        {
            starsActive = value;
            PonerEstrellas();
        }
    }

    public void PonerEstrellas()
    {
        star1.style.backgroundColor = new Color(0f, 0f, 0f, 0f);
        star2.style.backgroundColor = new Color(0f, 0f, 0f, 0f);
        star3.style.backgroundColor = new Color(0f, 0f, 0f, 0f);

        if (starsActive == 1)
        {
            star1.style.backgroundColor = Color.red;
        }
        else if (starsActive == 2)
        {
            star1.style.backgroundColor = Color.red;
            star2.style.backgroundColor = Color.red;
        }
        else if (starsActive == 3)
        {
            star1.style.backgroundColor = Color.red;
            star2.style.backgroundColor = Color.red;
            star3.style.backgroundColor = Color.red;
        }

       
    }

    public Lab4B()
    {
        star1.style.backgroundColor = new Color(0f, 0f, 0f, 0f);
        star2.style.backgroundColor = new Color(0f, 0f, 0f, 0f);
        star3.style.backgroundColor = new Color(0f, 0f, 0f, 0f);

        styleSheets.Add(Resources.Load<StyleSheet>("Lab4B"));

        star1.AddToClassList("stars");
        star2.AddToClassList("stars");
        star3.AddToClassList("stars");

        hierarchy.Add(star1);
        hierarchy.Add(star2);
        hierarchy.Add(star3);
    }
}
    

    
