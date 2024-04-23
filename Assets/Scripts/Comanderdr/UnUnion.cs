using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnUnion 
{
    // Start is called before the first frame update
    public UnUnion(string[] args, ConsoleController cc)
    {
        if (args.Length > 1)
        {
            GameObject gm = GameObject.Find(args[2]);
            new Select(args[1], cc);
            if (gm != null)
            {
                cc.InputText(gm.name + " Union");
                gm.transform.SetParent(null);
                cc.selectedObject = null;
            }
            else
            {
                cc.InputText("Not founded");
            }
        }
        else
            cc.InputText("Wrong!");
    }
}
