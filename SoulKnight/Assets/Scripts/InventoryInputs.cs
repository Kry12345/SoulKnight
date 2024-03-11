using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InventoryInputs : MonoBehaviour
{
    PlayerStats playerStats;
    CustomInput input;
    // Start is called before the first frame update
	void Awake()
	{
		input = new CustomInput();
        playerStats = gameObject.GetComponent<PlayerStats>();
	}
	private void OnInventoryOne()
    {
        playerStats.equipSlot(1);
    }
    private void OnInventoryTwo()
    {
        playerStats.equipSlot(2);
    }
    private void OnInventoryThree()
    {
        playerStats.equipSlot(3);
    }
    private void OnInventoryFour()
    {
        playerStats.equipSlot(4);
    }
    private void OnInventoryFive()
    {
        playerStats.equipSlot(5);
    }
    private void OnInventorySix()
    {
        playerStats.equipSlot(6);
    }
    private void OnInventoryUp()
    {
        playerStats.equipSlotUp();
    }
    private void OnInventoryDown()
    {
        playerStats.equipSlotDown();
    }
}
