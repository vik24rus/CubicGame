using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalDB : MonoBehaviour {
    public int playerHP = 100;
    public int sphereHP = 100;
    public int attakSphere = 25;
    public int attakPlayer = 5;
    public string PlayerName = "RigidBodyFPSController";

    bool PlayerDIE = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //public void PlayerGetDamage()
    //{

    //    while (playerHP > 0)
    //    {
    //        playerHP = playerHP - attakSphere;

    //        if (playerHP <= 0)
    //        {
    //            Debug.Log("УБИТ");
    //        }

    //    }

    //}ЗАДЕРЖКА НУЖНА!
    public void Go()
    {
        StartCoroutine(PlayerGetDamage());
    }

    public void Go2()
    {
        StopCoroutine(PlayerGetDamage());
    }
    public IEnumerator PlayerGetDamage()
    {

        
            playerHP = playerHP - attakSphere;

            if (playerHP <= 0)
            {
                Debug.Log("УБИТ");
            }
            yield return new WaitForSeconds(1000);

        

    }




    public void SphereGetDamage()
    {

    }
}
