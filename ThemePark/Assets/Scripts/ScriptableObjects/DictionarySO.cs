using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DictionarySO : ScriptableObject
{
    public Dictionary<String, List<GameObject>> dict;
}
