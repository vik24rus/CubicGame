﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIhealthbar : MonoBehaviour {
    private GlobalDB _GDB;
    [SerializeField]
    UnityEngine.UI.Slider slider;


    [SerializeField]
    Text TextArmor;

    [SerializeField]
    Text TextAtatak;
    // Use this for initialization
    void Start () {
        _GDB = GameObject.Find("GameManager").GetComponent<GlobalDB>(); //поиск скрипта по всем объектам в игре
        
    }
	
	// Update is called once per frame
	void Update () {
        slider.value = _GDB.playerHP;
        TextArmor.text = _GDB.PlayerDefend.ToString();
        TextAtatak.text = _GDB.PlayerAttak.ToString();
    }

}
