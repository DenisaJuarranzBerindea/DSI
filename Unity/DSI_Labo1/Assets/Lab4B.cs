using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab4B : VisualElement
{
    public new class UxmlFactory : UxmlFactory<Lab4B> { };

    public Lab4B()
    {
        VisualElement star1 = new VisualElement();
        VisualElement star2 = new VisualElement();
        VisualElement star3 = new VisualElement();
        VisualElement star4 = new VisualElement();
        VisualElement star5 = new VisualElement();

        styleSheets.Add(Resources.Load<StyleSheet>("StarsGroupStyle"));

        star1.AddToClassList("StarStyle");
        star2.AddToClassList("StarStyle");
        star3.AddToClassList("StarStyle");
        star4.AddToClassList("StarStyle");
        star5.AddToClassList("StarStyle");

        hierarchy.Add(star1);
        hierarchy.Add(star2);
        hierarchy.Add(star3);
        hierarchy.Add(star4);
        hierarchy.Add(star5);
    }


    VisualElement star1 = new VisualElement();
    VisualElement star2 = new VisualElement();
    VisualElement star3 = new VisualElement();
    VisualElement star4 = new VisualElement();
    VisualElement star5 = new VisualElement();

    [SerializeField] int starsActive = 0;

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
        if (starsActive == 0)
        {
            star1.visible = false;
            star2.visible = false;
            star3.visible = false;
            star4.visible = false;
            star5.visible = false;
        }
        else if (starsActive == 1)
        {
            star1.visible = true;
            star2.visible = false;
            star3.visible = false;
            star4.visible = false;
            star5.visible = false;
        }
        else if (starsActive == 2)
        {
            star1.visible = true;
            star2.visible = true;
            star3.visible = false;
            star4.visible = false;
            star5.visible = false;
        }
        else if (starsActive == 3)
        {
            star1.visible = true;
            star2.visible = true;
            star3.visible = true;
            star4.visible = false;
            star5.visible = false;
        }
        else if (starsActive == 4)
        {
            star1.visible = true;
            star2.visible = true;
            star3.visible = true;
            star4.visible = true;
            star5.visible = false;
        }
        else if (starsActive == 5)
        {
            star1.visible = true;
            star2.visible = true;
            star3.visible = true;
            star4.visible = true;
            star5.visible = true;
        }
    }



}
