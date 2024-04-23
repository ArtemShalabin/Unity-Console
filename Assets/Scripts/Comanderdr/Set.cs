using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set 
{
    // Start is called before the first frame update
    public Set(string[] args, ConsoleController cc)
    {
        if (args.Length < 2) 
        {
            cc.InputText("Wrong!");
        }
        else
        {
            switch (args[1])
            {
                case "color":
                    new SetColor(args, cc);
                    break;
                case "size":
                    new SetSize(args, cc);
                    break;
                case "rotate":
                    new SetRotation(args, cc);
                    break;
                case "position":
                    new SetPosition(args, cc);
                    break;
                case "time":
                    new SetTime(args, cc);
                    break;
                default:
                    cc.InputText("Wrong!");
                    break;
            }
        }


    }
}
