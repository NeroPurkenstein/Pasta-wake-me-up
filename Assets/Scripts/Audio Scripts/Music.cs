﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private AnxietyManager anxiety;

    private FMOD.Studio.EventInstance _music;

    private void Start()
    {
        _music = FMODUnity.RuntimeManager.CreateInstance("event:/Music/Music");
        _music.start();
    }

    private void Update()
    {
        if (anxiety.GetAnxiety() >= 90)
        {
            _music.setParameterValue("Anxiety", 90.0f);
        }
        else if (anxiety.GetAnxiety() <= 89)
        { 
            _music.setParameterValue("Anxiety", 89.0f);
        }
    }
}