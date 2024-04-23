using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSize
{
    // Start is called before the first frame update
    public SetSize(string[] args, ConsoleController cc)
    {
        if (args.Length > 5)
        {
            new Select(args[2], cc);
            if (cc.selectedObject != null)
            {
                cc.selectedObject.transform.localScale = new Vector3(float.Parse(args[3]), float.Parse(args[4]), float.Parse(args[5]));
                cc.selectedObject = null;
            }
            else
                cc.InputText("Not founded");
        }
        else
            cc.InputText("Wrong!");
    }
}
