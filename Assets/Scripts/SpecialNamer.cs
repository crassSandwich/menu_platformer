﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class SpecialNamer : MonoBehaviour
{
    public bool IsSpecial2;

    TextMeshProUGUI text;

    void Start ()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update ()
    {
        string content = "";

        switch (MageSquad.Instance.ActiveMage.Color)
        {
            case MagicColor.Red:
                content = IsSpecial2 ? "bombash" : "nimbility";
                break;

            case MagicColor.Green:
                content = IsSpecial2 ? "recoup" : "rejuve";
                break;

            case MagicColor.Blue:
                content = IsSpecial2 ? "???" : "embank";
                break;
        }

        text.text = content;
    }
}