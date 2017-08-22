using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sphere : MonoBehaviour {

    private GlobalDB _GDB;
    
    // Use this for initialization
    void Start () {
        _GDB = GameObject.Find("GameManager").GetComponent<GlobalDB>(); //поиск скрипта по всем объектам в игре
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.name.ToString() == _GDB.PlayerName)
    //    {
    //        //_GDB.PlayerGetDamage();
    //        _GDB.Go();
    //    }

    //}

    //void OnTriggerExit(Collider other)
    //{
    //    if (other.name.ToString() == _GDB.PlayerName)
    //    {
    //        //_GDB.PlayerGetDamage();
    //        _GDB.Go2();
    //    }

    //}
    void OnTriggerStay(Collider other)
    {
        if (other.name.ToString() == _GDB.PlayerName)
        {
            //_GDB.PlayerGetDamage();
            _GDB.Go();
        }

    }
}
