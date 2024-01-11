using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    //inventory array
    private string[] inventoryarray = new[] {"Sword","Shield","Potion"};
    
    //move element in the array to list
    private List<string> inventoryList;

        // Start is called before the first frame update
    void Start()
    {
        inventoryList = new List<string>(inventoryarray);
        DisplayInventory();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            inventoryList.Add("Helmet");
            DisplayInventory();
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            inventoryList.Remove("Sword");
            DisplayInventory();
        }
    }

    void DisplayInventory()
    {
        int i = 1;
        Debug.Log($"Inventory: {inventoryList}");
        foreach (var Item in inventoryList)
        {
            Debug.Log($"{i}.{Item}");
            i++;
        }
    }
}
