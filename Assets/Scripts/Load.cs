﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load : MonoBehaviour
{

    private static bool audioExists;

    // Start is called before the first frame update
    void Start()
    {
        if (!audioExists)
        {
            audioExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
