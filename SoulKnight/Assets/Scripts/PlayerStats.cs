using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float health;
    items[] inventory = {items.empty, items.empty, items.empty, items.gun, items.empty, items.empty};
    int selectedSlot = 0;

    public items[] getInventory()
    {
        return inventory;
    }
    
    public int getEquippedSlot()
    {
        return selectedSlot;
    }

    public void recieveDamage(float damage)
    {
        health -= damage;
    }
    
    void Update()
    {
        print(selectedSlot);
    }

    public void equipSlot(int slotNum)
    {
        selectedSlot = slotNum;
    }

    public void equipSlotUp()
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

    public void equipSlotDown()
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