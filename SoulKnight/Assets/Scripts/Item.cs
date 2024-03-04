using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public items itemType;
}

public enum items
{
    empty,
    sword,
    pistol,
    magicWand
}

