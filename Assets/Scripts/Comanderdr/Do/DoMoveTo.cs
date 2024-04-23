using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoMoveTo 
{
    // Start is called before the first frame update
    // Start is called before the first frame update
    public DoMoveTo(string[] args, ConsoleController cc)
    {
        if (args.Length > 6)
        {
            new Select(args[2], cc);
            if (cc.selectedObject != null)
            {
                GameObject gm = GameObject.Find(args[4]);
                if (gm != null)
                {
                    cc.selectedObject.transform.DOMove(gm.transform.position + new Vector3(float.Parse(args[5]), float.Parse(args[6]), float.Parse(args[7])), float.Parse(args[8]));
                    cc.selectedObject = null;
                }
                else
                {
                    cc.InputText("Wrong!");
                }
            }
            else
                cc.InputText("Not founded");
        }
        else
            cc.InputText("Wrong!");
    }
}

