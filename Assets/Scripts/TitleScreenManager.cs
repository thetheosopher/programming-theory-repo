using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    public TMP_InputField nameInputField;
    public Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        nameInputField.Select();
        nameInputField.ActivateInputField();
    }

    // Update is called once per frame
    void Update()
    {
        startButton.interactable = !string.IsNullOrEmpty(nameInputField.text.Trim());
    }

    public void StartButtonClick()
    {
        DataManager.Instance.PlayerName = nameInputField.text;
        SceneManager.LoadScene(1);
    }
}
