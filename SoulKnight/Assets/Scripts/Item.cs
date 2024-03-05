using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] items item;

    public items itemType()
    {
        return item;
    }
}



public enum items
{
    empty,
    sword,
    pistol,
    magicWand,
    gun
}

