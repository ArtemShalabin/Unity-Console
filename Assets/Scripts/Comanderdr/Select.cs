using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select
{
    // Start is called before the first frame update
    public Select(string name, ConsoleController cc)
    {
        if (name.Length > 0)
        {
            GameObject gm = GameObject.Find(name);
            if (gm != null)
            {
                cc.InputText(gm.name + " Selected");
                cc.selectedObject = gm;
            }
            else
            {
                cc.InputText("Not founded");
            }
        }
    }
}
