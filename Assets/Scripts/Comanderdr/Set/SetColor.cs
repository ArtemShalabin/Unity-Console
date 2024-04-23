using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor 
{
    // Start is called before the first frame update
    public SetColor(string[] args, ConsoleController cc)
    {
        if (args.Length > 5)
        {
            new Select(args[2], cc);
            if (cc.selectedObject != null)
            {
                cc.selectedObject.GetComponent<MeshRenderer>().material.color = new Color(float.Parse(args[3])/100, float.Parse(args[4])/100, float.Parse(args[5])/100);
                cc.selectedObject = null;
            }
            else
                cc.InputText("Not founded");
        }
        else
            cc.InputText("Wrong!");
    }
}
