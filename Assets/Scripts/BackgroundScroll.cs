﻿using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-0.01f, 0));
    }
}
