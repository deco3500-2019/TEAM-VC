﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadingGame()
    {
        Application.LoadLevel("mianScene");
    }
}
