using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Scriptable Objects/Item")]
public class Item : ScriptableObject
{
    [Header("Only gameplay")]
    public ToolboxItemFilterType type;
    public ItemType itemType;
    public ActionType actionType;
    public Vector3Int range = new Vector3Int(5,4);

    [Header("Only Ui")]
    public bool stackable = false;

    [Header("Both")]
    public Sprite image;

    public enum ItemType
    {
        Tool,
        Weapon,
        Utility
    }
    public enum ActionType
    {
        Cast,
        Shoot,
        Melee,
        Use
    }
}
