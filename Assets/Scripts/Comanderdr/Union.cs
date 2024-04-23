using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Union 
{
    // Start is called before the first frame update
    public Union(string[] args, ConsoleController cc)
    {
        if (args.Length > 1)
        {
            GameObject gm = GameObject.Find(args[2]);
            new Select(args[1], cc);
            if (gm != null)
            {
                cc.InputText(gm.name + " Union");
                gm.transform.SetParent(cc.selectedObject.transform, true);
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
