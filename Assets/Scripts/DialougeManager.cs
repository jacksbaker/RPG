﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialougeManager : MonoBehaviour
{

    public GameObject dBox;
    public Text dText;

    public bool dialogActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogActive && Input.GetKeyDown(KeyCode.Space)) 
        {
            dBox.SetActive(false);
            dialogActive = false;
        }
    }

    public void ShowBox(string dialouge)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialouge;
    }

}
