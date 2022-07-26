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

    public void UpdateName()
    {
        DataManager.Instance.PlayerName = nameInputField.text;
    }

    // Update is called once per frame
    void Update()
    {
        startButton.interactable = DataManager.Instance.NameIsValid;
    }

    public void StartButtonClick()
    {
        DataManager.Instance.PlayerName = nameInputField.text;
        SceneManager.LoadScene(1);
    }
}
