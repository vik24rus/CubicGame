using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_ : MonoBehaviour
{
    private GlobalDB _GDB;
   
    public GameObject Pricel;
    public GameObject EndGameText;
    public GameObject EndGameCamera;
    
    public GameObject Sphere;
    public GameObject SphereDie;
    // Use this for initialization
    void Start()
    {
        _GDB = GameObject.Find("GameManager").GetComponent<GlobalDB>(); //поиск скрипта по всем объектам в игре

    }
    // Update is called once per frame
    void Update()
    {
        if (_GDB.playerHP <= 0)
        {
            
            Destroy(Pricel);
            
            _GDB.Gamer.SetActive(false);
            
               
            EndGameCamera.SetActive(true);
            EndGameText.SetActive(true);
            
            

        }
        if(_GDB.sphereHP <= 0)
        {

           
            Sphere.SetActive(false);
            SphereDie.SetActive(true);


        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}