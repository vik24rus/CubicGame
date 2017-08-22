using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sphere : MonoBehaviour {

    private GlobalDB _GDB;

    public float AttackDelay;
    private float _attackDelay;
    
    void Start () {
        _GDB = GameObject.Find("GameManager").GetComponent<GlobalDB>(); //поиск скрипта по всем объектам в игре
    }
	
	// Update is called once per frame
	void Update () {
       
    }


   void OnTriggerStay(Collider other) 
   {
        if (_attackDelay < AttackDelay)//если _задержка меньше Задержки которую указали вы то - ждем пока не накапают секунды до того числа которое мы указали и если накапали то идем дальше
        {
            _attackDelay += Time.deltaTime;//прибавляем 1 сек
            

        } else
        {

            if (other.name.ToString() == _GDB.PlayerName)
            {

                _GDB.playerHP = _GDB.playerHP - _GDB.attakSphere;
                _attackDelay = 0f;//обнуляем _зажержку

            }

        }
        
    }

    void OnTriggerExit()
    {
        _attackDelay = 0;//обнуление переменной при выходе из триггера


        //все работает урон наноситься раз в секунду. ой раз в определенное вами время. не забывайте указать тег у игрока. всем спасибо досвидание.
    }
}
