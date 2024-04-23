using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRotation
{
    public SetRotation(string[] args, ConsoleController cc)
    {
        if (args.Length > 5)
        {
            new Select(args[2], cc);
            if (cc.selectedObject != null)
            {
                cc.selectedObject.transform.eulerAngles = new Vector3(float.Parse(args[3]), float.Parse(args[4]), float.Parse(args[5]));
                cc.selectedObject = null;
            }
            else
                cc.InputText("Not founded");
        }
        else
            cc.InputText("Wrong!");
    }
}
