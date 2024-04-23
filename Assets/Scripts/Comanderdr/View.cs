using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View 
{
    // Start is called before the first frame update
    public View(string[] args, ConsoleController cc)
    {
        if (args.Length > 1)
        {
            GameObject gm = GameObject.Find(args[1]);
            if (gm != null)
            {
                Camera.main.transform.position = gm.transform.position + new Vector3(float.Parse(args[2]), float.Parse(args[3]), float.Parse(args[4]));
                Camera.main.transform.LookAt(gm.transform.position);
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
