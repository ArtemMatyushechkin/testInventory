using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item")]
public class ItemObjcet : ScriptableObject
{
    public new string name;
    public string description;
    public Sprite icon;
    public int cost;
   
    public ItemTypes selectItemType = new ItemTypes();
    public enum ItemTypes
    {
        Sword,
        Axe,
        Ranged,
        Resource,
        Usable
     
    }
}
