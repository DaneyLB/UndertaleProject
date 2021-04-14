﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DialogueSystem
{
    public class DialogueLine : DialogueBaseClass
    {
        private Text textHolder;

        [SerializeField] private string input;
        [SerializeField] private AudioClip sound;


        private void Awake()
        { 
            textHolder = GetComponent<Text>();

            StartCoroutine(WriteText(input, textHolder, sound));
        }
    }
}
