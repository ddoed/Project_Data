using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item Data", menuName = "GameData/ItemData")]
public class ItemData : ScriptableObject
{
    public enum ItemType { Tool, Container, Book, Food }
    public ItemType type = ItemType.Tool;
    public int id = -1;
    public string name = "�̸�";
    public string description = "����";
    public Sprite itemIcon = null;
    
}
