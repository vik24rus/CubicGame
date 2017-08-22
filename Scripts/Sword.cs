using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour {

    int SwordDamage = 2;
    private GlobalDB _GDB;
    // Use this for initialization
    void Start()
    {
        _GDB = GameObject.Find("GameManager").GetComponent<GlobalDB>(); //поиск скрипта по всем объектам в игре
    }

    // Update is called once per frame
    void Update () {
		
	}
}
