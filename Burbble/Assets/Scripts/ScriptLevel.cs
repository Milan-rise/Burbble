using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UIElements;



[CreateAssetMenu(fileName = "NewLevel", menuName = "Level/Create New Level")]
public class Level : ScriptableObject
{

    [Header("Fischarten (6 Werte)")]
    public int[] fischarten = new int[6];

    [Header("Zielt�ne (6 Werte)")]
    public int[] zielt�ne = new int[6];
}

