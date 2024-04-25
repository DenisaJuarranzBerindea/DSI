using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UxmlFactory : UxmlFactory<Lab4B, UxmlTraits> { };

public class UxmlTraits : VisualElement.UxmlTraits
{

    UxmlIntAttributeDescription myStarsActive = new UxmlIntAttributeDescription { name = "stars", defaultValue = 0 };

    public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
    {
        base.Init(ve, bag, cc);
        var stars = ve as Lab4B;
        stars.Estado = myStarsActive.GetValueFromBag(bag, cc);
        Debug.Log("stars.number: " + stars.Estado);
    }
}
