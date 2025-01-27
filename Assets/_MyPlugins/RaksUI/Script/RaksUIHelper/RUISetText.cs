﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class RUISetText : MonoBehaviour
{
    #region //----> Variable
    private Text t;
    public RUITextType textType;
    #endregion
    #region //----> Method
    private void Awake()
    {
        t = GetComponent<Text>();
    }
    public string SetText { set { t.text = value; } }
    #endregion
}

public enum RUITextType
{
    title = 0,
    text = 1
}
