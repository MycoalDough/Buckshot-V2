﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayer : MonoBehaviour
{
    public GameManager gm;

    private void Awake()
    {
        gm = GameObject.FindObjectOfType<GameManager>().GetComponent<GameManager>();
    }
    void Update()
    {
        if(gm.turn == "b" && gm.play)
        {

        }
    }
}
