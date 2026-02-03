using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameText : MonoBehaviour
{
    public string nameText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void getName()
    {
        nameText = gameObject.GetComponent<Text>().text;
    }
}
