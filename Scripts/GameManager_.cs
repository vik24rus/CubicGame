using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_ : MonoBehaviour
{
    private GlobalDB _GDB;
    public GameObject Pricel;
    public GameObject EndGameText;
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
            Destroy(_GDB.Gamer);
            Destroy(Pricel);
            EndGameText.SetActive(true);
        }
    }
}