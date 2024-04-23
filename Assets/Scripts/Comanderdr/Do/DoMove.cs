using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoMove
{
    // Start is called before the first frame update
    public DoMove(string[] args, ConsoleController cc)
    {
        if (args[3] == "to")
        {
            new DoMoveTo(args,cc);
            return;
        }
        if (args.Length > 6)
        {
            new Select(args[2], cc);
            if (cc.selectedObject != null)
            {
                cc.selectedObject.transform.DOMove(new Vector3(float.Parse(args[3]), float.Parse(args[4]), float.Parse(args[5])), float.Parse(args[6]));
                cc.selectedObject = null;
            }
            else
                cc.InputText("Not founded");
        }
        else
            cc.InputText("Wrong!");
    }
}
