using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create
{
    public Create(string[] args,ConsoleController cc)
    {
        if (args.Length < 3)
        {
            cc.InputText("Wrong!");
            return;
        }
        switch (args[1])
        {
            case "cube":
                GameObject.CreatePrimitive(PrimitiveType.Cube).name = args[2];
                break;
            case "sphere":
                GameObject.CreatePrimitive(PrimitiveType.Sphere).name = args[2];
                break;
            case "cylinder":
                GameObject.CreatePrimitive(PrimitiveType.Cylinder).name = args[2];
                break;
            case "capsule":
                GameObject.CreatePrimitive(PrimitiveType.Capsule).name = args[2];
                break;
            default:
                cc.InputText("Wrong!");
                break;
        }
    }
}
