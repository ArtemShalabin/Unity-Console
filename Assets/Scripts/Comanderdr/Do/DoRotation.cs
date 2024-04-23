using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoRotation
{
    // Start is called before the first frame update
    public DoRotation(string[] args, ConsoleController cc)
    {
        if (args.Length > 5)
        {
            new Select(args[2], cc);
            if (cc.selectedObject != null)
            {
                cc.selectedObject.transform.DORotate(new Vector3(float.Parse(args[3]), float.Parse(args[4]), float.Parse(args[5])), float.Parse(args[6]));
                cc.selectedObject = null;
            }
            else
                cc.InputText("Not founded");
        }
        else
            cc.InputText("Wrong!");
    }
}
