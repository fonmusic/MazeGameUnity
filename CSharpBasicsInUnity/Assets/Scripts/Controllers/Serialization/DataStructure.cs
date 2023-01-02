using System;
using UnityEngine;

[Serializable]
public struct Svect3
{
    public float X;
    public float Y;
    public float Z;

    public Svect3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static implicit operator Svect3(Vector3 vector3)
    {
        return new Svect3(vector3.x, vector3.y, vector3.z);
    }


    public static implicit operator Vector3(Svect3 svect3 )
    {
        return new Vector3(svect3.X, svect3.Y, svect3.Z);
    }

    //public override string ToString() => $" (X = {X} Y = {Y} Z = {Z})";
}
