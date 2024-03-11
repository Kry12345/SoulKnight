using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayInventorySlots : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] slotNumber inventorySlot;
    RectTransform rectTransform;
    PlayerStats playerStats;
    Image image;
    ItemInfo itemInfo;
    // Start is called before the first frame update
    void Start()
    {
        
        playerStats = player.GetComponent<PlayerStats>();
        image = GetComponent<Image>();
        rectTransform = GetComponent<RectTransform>();
        itemInfo = transform.Find("ItemInfo").GetComponent<ItemInfo>();
    }
    // Update is called once per frame
    void Update()
    {
        if ((int)inventorySlot == playerStats.getEquippedSlot())
        {
            rectTransform.localScale = new Vector2(1.2f, 1.2f);
        }
        else
        {
            rectTransform.localScale = new Vector2(1f, 1f);
        }
        if (playerStats.getInventory()[(int)inventorySlot] == items.gun)
        {
            image.sprite = itemInfo.getGunImg();
        }
        else
        {
            image.sprite = itemInfo.getEmptyImg();
        }
    }
}

public enum slotNumber
{
    one = 0,
    two = 1,
    three = 2,
    four = 3,
    five = 4,
    six = 5
}
