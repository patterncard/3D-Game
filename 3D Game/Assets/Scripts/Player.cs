﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigitbody playerBody;
    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigitbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}