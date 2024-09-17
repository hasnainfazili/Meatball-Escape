using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
  public static BGM backgroundMusic;

    void Awake()
    {
        DontDestroyOnLoad(this);
        if(backgroundMusic == null)
            backgroundMusic = this;
        else DestroyObject(gameObject);
    }
}
