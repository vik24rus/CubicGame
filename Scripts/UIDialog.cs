using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIDialog : MonoBehaviour {

    public Text CubicText;
    public GameObject Panel;
    private GlobalDB _GDB;
    // Use this for initialization
    void Start () {
        _GDB = GameObject.Find("GameManager").GetComponent<GlobalDB>(); //поиск скрипта по всем объектам в игре
    }
	
	// Update is called once per frame
	void Update () {
        if (_GDB.CubicSayBool == false)
        {
            CubicText.text = "ПССС, парень. Убей шарик.";
        }
        if (_GDB.CubicSayBool == true)
        {
            Panel.SetActive(false);
            CubicText.text = _GDB.CubicSay;
        }
    }
}
