using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SampleScreenManager : MonoBehaviour
{
    public TMP_Text welcomeText;

    // Start is called before the first frame update
    void Start()
    {
        welcomeText.text = $"Hi {DataManager.Instance.PlayerName}. How's it going?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
