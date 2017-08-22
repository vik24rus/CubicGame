using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {
    
    [SerializeField]
    GameObject CubeText;

    [SerializeField]
    GameObject UI_NPC_Dialog;

    private GlobalDB _GDB;
    // Use this for initialization
    void Start () {
        _GDB = GameObject.Find("GameManager").GetComponent<GlobalDB>(); //поиск скрипта по всем объектам в игре
    }
	
	// Update is called once per frame
	void Update () {
                     

    }
    void OnTriggerEnter(Collider other)  //проверка что подошел именно игрок тригером - можно на колизиях сделать
    {
        
        if(other.name.ToString() == _GDB.PlayerName)
        {
            Destroy(CubeText);
            UI_NPC_Dialog.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //кубик скажет вперед!
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
           //кубик скажет ты лох!
        }
    }


    void OnTriggerExit(Collider other)
    {
        if (other.name.ToString() == _GDB.PlayerName)
        {
            Destroy(CubeText);
        UI_NPC_Dialog.SetActive(false);
        }
    }
}
