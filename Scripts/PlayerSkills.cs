using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour {
    private GlobalDB _GDB;
    void Start () {
        _GDB = GameObject.Find("GameManager").GetComponent<GlobalDB>(); //поиск скрипта по всем объектам в игре
    }
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E))
        {
            getItem();
        }
	}

    void getItem()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray , out hit, 2 , 1<<8)) //луч, удар , дистанция , слой куда бить
        {
            //Transform objectHit = hit.transform;
             Destroy(hit.transform.gameObject);
            // забрать предмет в инвентарь с помощью луча

        }
        
    }

    
}
