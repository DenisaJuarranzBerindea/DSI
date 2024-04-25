using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Lab4 : MonoBehaviour
{

    void OnEnable()
    {
        VisualElement rootve = GetComponent<UIDocument>().rootVisualElement;

        //Texto Enriquecido
        Label charTitle = rootve.Q<Label>("CharactersTitle");
        Label weapTitle = rootve.Q<Label>("WeaponsTitle");

        charTitle.text = @"<color=""red""><i> Choose your Character </i></color>";
        weapTitle.text = @"<color=""blue""><rotate=""30""> Choose your Weapon </rotate></color>";




    }





}
