using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] items item;

    public items itemType() // accessor method that returns the item type based off of the enum
    {
        return item;
    }
}



public enum items // contains names of all the items in the game
{
    empty,
    sword,
    pistol,
    magicWand,
    gun
}

