using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    float health;
    items[] inventory = {items.empty, items.empty, items.empty, items.gun, items.empty, items.empty};

    public items[] getInventory()
    {
        return inventory;
    }
    
    void Update()
    {

    }

}