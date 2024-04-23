using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConsoleController : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;
    private bool isConsoleActive;
    [SerializeField]
    private TextMeshProUGUI consoleText;
    [SerializeField]
    private TMP_InputField consoleInputField;
    public GameObject selectedObject;
    // Start is called before the first frame update
    void Start()
    {
        consoleInputField.onEndEdit.AddListener(EndEditText);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.BackQuote))
        {
            if(isConsoleActive == false)
            {
                canvas.enabled = true;
                isConsoleActive = true;
            }
            else
            {
                canvas.enabled = false;
                isConsoleActive = false;
            }
            
        }
        
    }
    public void InputText(string text)
    {
        consoleText.text += '\n' + text;

        
    }
    private void EndEditText(string text)
    {
        InputText(consoleInputField.text);
        ProccesCommand(text);
        consoleInputField.text = string.Empty;
    }
    private void ProccesCommand(string command)
    {
        string[] argr = command.Split(' ');
        if (argr.Length == 0)
        {
                InputText("Wrong!");
                return;
        }
        string cmd = argr[0].ToLower();
        switch (cmd)
        {
            case "/set":
                new Set(argr,this);
                break;
            case "/create":
                new Create(argr, this);
                break;
            case "/delete":
                new Delete(argr,this);
                break;
            case "/do":
                new Do(argr,this);
                break;
            case "/view":
                new View(argr,this);
                break;
            case "/union":
                new Union(argr,this);
                break;
            case "/ununion":
                new UnUnion(argr,this);
                break;
            default:
                InputText("Wrong!");
                break;
        }
    }


}

