using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDB : MonoBehaviour {
    public int playerHP = 100;
    public int sphereHP = 100;
    public int attakSphere = 15;
    public int attakPlayer = 5;
    public string PlayerName = "RigidBodyFPSController";

    bool PlayerDIE = false;

    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerHP <= 0)
        {
            //Debug.Log("УБИТ");
        }
    }

           
    
    public void SphereGetDamage()
    {

    }
}
