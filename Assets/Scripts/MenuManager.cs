using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuManager : MonoBehaviour
{
    public Canvas canvas;
    public string nameText;
    public TMP_InputField nameField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nameField.onEndEdit.AddListener(getName);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }

    public void getName(string x)
    {
        nameText = x;
        SaveManager.UserName = nameText;
        Debug.Log(x);
    }
}
