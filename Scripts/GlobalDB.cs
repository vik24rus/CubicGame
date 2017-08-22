using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDB : MonoBehaviour {
    public int playerHP = 100;
    public int sphereHP = 100;
    public int attakSphere = 15;
    public int attakPlayer = 5;
    public string PlayerName;
    public float AttackDelaySphere = 2;
    
    public int PlayerDefend = 1;
    public int PlayerAttak = 1;

    

    [SerializeField]
    public GameObject Gamer;

    public List<string> Inventar = new List<string>();
    public bool inventarChange = false;
    public bool swordOn= false;
    public bool armorOn = false; // типа подняли и у нас в инвентаре
    public int ArmorDefend = 10;
    public int SwordDamage = 49;

    public string CubicSay = "";
    public bool CubicSayBool= false;

    public bool armorOnPlayer = false; //типа надето на нас
    
    public bool swordOnPlayer = false;
    // Use this for initialization
    void Start () {
        PlayerName = Gamer.name;
        

    }
	
	// Update is called once per frame
	void Update () {
        EquipmentBonus();
    }


    void EquipmentBonus()
    {

        if (armorOn == true && armorOnPlayer == true)
        {
            PlayerDefend = PlayerDefend + ArmorDefend;
            armorOnPlayer = false;
        }

        if (swordOn == true && swordOnPlayer == true)
        {
            PlayerAttak = PlayerAttak + SwordDamage;
            swordOnPlayer = false;
        }
        
    }



}
