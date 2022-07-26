using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    private string playerName;
    public string PlayerName 
    { 
        get { return playerName; }
        set 
        { 
            if(string.IsNullOrEmpty(value.Trim()))
            {
                Debug.LogError("Name cannot be empty.");
            }
            else
            {
                playerName = value;
            }
        }
    }

    public bool NameIsValid
    {
        get { return !string.IsNullOrEmpty(playerName.Trim()); }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
