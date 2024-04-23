using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTime
{
    // Start is called before the first frame update
    public SetTime(string[] args, ConsoleController cc)
    {
        if (args.Length > 1)
        {
            Time.timeScale = float.Parse(args[2]);
        }
        else
            cc.InputText("Wrong!");
    }
}
