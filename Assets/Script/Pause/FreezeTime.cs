using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeTime : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 0;
    }
}
