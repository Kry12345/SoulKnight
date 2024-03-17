using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float health; // keeps track of the health of the player
    items[] inventory = {items.empty, items.empty, items.empty, items.gun, items.empty, items.empty}; // Stores the players inventory using values from the items enum found in the Item script
    int selectedSlot = 0; // keeps track of the selected slot

    public items[] getInventory() // accessor method to get the inventory slot
    {
        return inventory;
    }
    
    public int getEquippedSlot() // accessor method to get the equipped slot
    {
        return selectedSlot;
    }

    public void recieveDamage(float damage) // mutator method that adjusts the value of health
    {
        health -= damage;
    }

    public void equipSlot(int slotNum) // mutator method that sets the equipped slot based off inputs (found in InventoryInput script)
    {
        selectedSlot = slotNum;
    }

    public void equipSlotUp() // mutator method that adds one to the equipped slot based off inputs (for controller) (found in InventoryInput script)
    {
        if (selectedSlot + 1 > inventory.Length - 1)
        {
            selectedSlot = 0;
        }
        else
        {
            selectedSlot += 1;
        }
    }

    public void equipSlotDown() // mutator method that subtracts one to the equipped slot based off inputs (for controller) (found in InventoryInput script)
    {
        if (selectedSlot - 1 < 0)
        {
            selectedSlot = 5;
        }
        else
        {
            selectedSlot -= 1;
        }
    }

}