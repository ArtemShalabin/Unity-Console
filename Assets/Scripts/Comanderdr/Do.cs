using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Do
{
    // Start is called before the first frame update
    public Do(string[] args, ConsoleController cc)
    {
        if (args.Length < 2)
        {
            cc.InputText("Wrong!");
        }
        else
        {
            switch (args[1])
            {
                case "move":
                    new DoMove(args, cc);
                    break;
                case "rotate":
                    new DoRotation(args, cc);
                    break;
                case "scale":
                    new DoScale(args, cc);
                    break;
                case "color":
                    new DoColor(args, cc);
                    break;
                case "view":
                    new DoView(args, cc);
                    break;
                
                default:
                    cc.InputText("Wrong!");
                    break;
            }
        }


    }
}
