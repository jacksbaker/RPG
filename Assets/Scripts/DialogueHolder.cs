﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour
{

    public string dialogue;
    private DialougeManager dMAn;

    // Start is called before the first frame update
    void Start()
    {
        dMAn = FindObjectOfType<DialougeManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                dMAn.ShowBox(dialogue);
            }
        }
    }

}
