using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour {
    private GlobalDB _GDB;

    [SerializeField]
    Text InventoryText;

    
    
    void Start()
    {
        _GDB = GameObject.Find("GameManager").GetComponent<GlobalDB>(); //поиск скрипта по всем объектам в игре
        
    }

    // Update is called once per frame
    void Update () {
        if (_GDB.Inventar.Count == 0 )
        {
            InventoryText.text = "Ничего нет :(";
        }
        if (_GDB.Inventar.Count != 0 && _GDB.inventarChange == true)
        {
            InventoryText.text = " ";
            for (int i = 0; i < _GDB.Inventar.Count; i++)
            {
                InventoryText.text += _GDB.Inventar[i].ToString() + " \n";

            }
            _GDB.inventarChange = false;
        }
    }
    
}
