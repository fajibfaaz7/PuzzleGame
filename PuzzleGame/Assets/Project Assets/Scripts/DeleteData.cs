﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteData : MonoBehaviour
{
   public void Delete()
    {
        PlayerPrefs.DeleteKey("levelReached");
    }
}
