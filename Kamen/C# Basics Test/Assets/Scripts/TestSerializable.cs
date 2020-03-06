﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TestSerializable : MonoBehaviour {

    [SerializeField]
    [Range(0, 10)]
    private float testFloat;

    [SerializeField]
    private int testInt;

    void Start() {
        Test test = new Test();
        test.Stats.hasHealthPotion = false;
    }

    // Update is called once per frame
    void Update() {

    }
}