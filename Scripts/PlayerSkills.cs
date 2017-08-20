using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour {
    

    

	void Start () {
		
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
            Debug.Log("Берем предмет");
            Transform objectHit = hit.transform;
            Debug.Log(objectHit.name);
            // забрать предмет в инвентарь с помощью луча
            
        }
        
    }
}
