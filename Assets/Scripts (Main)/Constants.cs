﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using UnityEngine;

[Serializable]
public class MainCore
{
   public School[] shcools { get; set; }
}

[CreateAssetMenu(menuName = "Constants")]
public class Constants : ScriptableObject
{
    public MainCore mainCore = new MainCore();
    public uint focusedShcoolIndex;
    public KeyValuePair<string, string> questionanswercache;
    public uint focusedSubjectIndex;

    public bool bad;
    public bool ok;
    public bool good;

    public Subject feededSubject;

    public bool Useless;

    public void Serialize()
    {
       new SavingSystem<MainCore>().SaveAsJson(mainCore,"SaveFile.X1SaveFile");

    }
    public void Deserialize()
    {
        var i = new SavingSystem<MainCore>().LoadAsJson("SaveFile.X1SaveFile");
        if (i == null) { return; }
        mainCore = i;
    }
}


