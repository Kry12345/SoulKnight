using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] float health;
    items[] inventory = {items.empty, items.empty, items.empty, items.gun, items.empty, items.empty};

    public items[] getInventory()
    {
        return inventory;
    }

    public void recieveDamage(float damage)
    {
        health -= damage;
    }
    
    void Update()
    {
        
    }

}