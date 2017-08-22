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
    public bool armorOn = false;
    public int ArmorDefend = 10;
    public int SwordDamage = 2;
    // Use this for initialization
    void Start () {
        PlayerName = Gamer.name;
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    //1. бой - удар игрока с учетом снаряги и зашита
    //2. диалог
           
    
    
}
