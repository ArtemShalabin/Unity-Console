using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete
{
    // Start is called before the first frame update


    public Delete(string[] args, ConsoleController cc)
    {
        if (args.Length > 1)
        {
            GameObject gm = GameObject.Find(args[1]);
            if (gm != null)
            {
                cc.InputText(gm.name + " Deleted");
                GameObject.Destroy(gm);
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
