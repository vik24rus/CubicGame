using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour {
    private GlobalDB _GDB;

    
    private Fight fight;
    void Start()
    {
        _GDB = GameObject.Find("GameManager").GetComponent<GlobalDB>(); //поиск скрипта по всем объектам в игре
        fight = GameObject.Find("GameManager").GetComponent<Fight>(); //поиск скрипта по всем объектам в игре
    }


    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.E))
        {
            getItem();
        }

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            punch();
            
        }
	}

    void getItem()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray , out hit, 2 , 1<<8)) //луч, удар , дистанция , слой куда бить
        {
            Destroy(hit.collider.gameObject);
            if (hit.collider.name == "Sword")
            {
                _GDB.swordOn = true;
                _GDB.Inventar.Add(hit.collider.name.ToString());
                _GDB.inventarChange = true;
            }
            if (hit.collider.name == "Armor")
            {
                _GDB.swordOn = true;
                _GDB.Inventar.Add(hit.collider.name.ToString());
                _GDB.inventarChange = true;
            }

        }

    }

    void punch()
    {
        
         
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 4)) //луч, удар , дистанция
            {
                
                if (hit.collider.tag.ToString() == "Enemy" ) //смотрим тег объекта
                {
                    fight.PlayerAttak();
                    
                }            
                

            }

        }
    }


