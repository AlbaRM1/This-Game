using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorDestroyer : MonoBehaviour
{
    public void Destroyer(GameObject Popup)
    {
        Time.timeScale = 1;
        Destroy(Popup);
    }
}
