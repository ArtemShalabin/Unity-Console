using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoView 
{
    // Start is called before the first frame update
    public DoView(string[] args, ConsoleController cc)
    {
        if (args.Length > 1)
        {
            GameObject gm = GameObject.Find(args[2]);
            if (gm != null)
            {
                Camera.main.transform.DOMove(gm.transform.position + new Vector3(float.Parse(args[3]), float.Parse(args[4]), float.Parse(args[5])), float.Parse(args[6]))
                    .OnUpdate(() =>
                    {
                        Camera.main.transform.LookAt(gm.transform.position);
                    });
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
