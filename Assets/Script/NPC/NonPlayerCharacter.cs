using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

[UnityEngine.CreateAssetMenu(fileName = "NPCData", menuName = "NPC", order = 0)]
public class NonPlayerCharacterData : ScriptableObject
{
    private string _name;
    private string _title;

    [NonSerialized] 
    private string[] _chatOptions;

    public Item[] inventory;

    public NPCType NpcType;

    public enum NPCType
    {
        Shop,
        Enemy,
    }

}
