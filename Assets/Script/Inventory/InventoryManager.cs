using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    private float weight { set; get; }

    public List<Item> inventory;

    public void AddItem(Item addingItem,int amount)
    {
        if (addingItem.isStackable)
        {
            addingItem.amount = amount;
        }
        else
        {
            for (var i = 1; i < amount; i++)
            {
                inventory.Add(addingItem);
            }
        }
        
        inventory.Add(addingItem);
        weight += addingItem.weight * amount;
    }
    
    
    
    
    
}
