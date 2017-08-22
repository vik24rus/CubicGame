using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDB : MonoBehaviour {
    public int playerHP = 100;
    public int sphereHP = 100;
    public int attakSphere = 15;
    public int attakPlayer = 5;
    public string PlayerName;
    public float AttackDelay = 2;

    public bool PlayerDIE = false;

    [SerializeField]
    public GameObject Gamer;

    // Use this for initialization
    void Start () {
        PlayerName = Gamer.name;
	}
	
	// Update is called once per frame
	void Update () {
        
    }

           
    
    
}
