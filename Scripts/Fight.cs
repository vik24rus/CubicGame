using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour {
    private GlobalDB _GDB;
    // Use this for initialization
    void Start () {
        _GDB = GameObject.Find("GameManager").GetComponent<GlobalDB>(); //поиск скрипта по всем объектам в игре
    }

	public void SphereAttak()
    {
        _GDB.playerHP = _GDB.playerHP - (_GDB.attakSphere - _GDB.PlayerDefend); 
    }

    public void PlayerAttak()
    {
        _GDB.sphereHP = _GDB.sphereHP - _GDB.PlayerAttak ;
        
    }
	// Update is called once per frame
	void Update () {
		
	}
}
