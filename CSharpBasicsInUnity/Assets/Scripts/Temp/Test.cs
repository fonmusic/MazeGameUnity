using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Maze;


public abstract class User
{
    public virtual void Move(int x, int y)
    {
        Debug.Log("Move");
    }
}


public class NewUser: User, Irotation
{
    private string name;
    private int health;
    private int id;

    

    public NewUser(string name, int health, int id)
    {
        this.Name = name;
        this.Health = health;
        this.Id = id;
        Debug.Log(this.Name);
    }

    public string Name
    {
        get
        {
            return name;
        } 
        set
        {
            name = value;
        } 
    }

    public int Health
    {
        get
        {
            return health * 100;
        } 
        set
        {
            if (value <= 100 && value >= 0)
                health = value;
            else Debug.Log("wrong number");
        } 
    }



    public int Id { get => id; set => id = value; }

    public override void Move(int x, int y)
    {
        Debug.Log("New Move");
    }

    public void Rotate()
    {

    }
}

public class Test : MonoBehaviour
{

    struct User
    {
        public string name;
        public int health;
        public int id;
    }

    NewUser myClass;

    
    void Start()
    {
        User user = new User();
        user.health = 100;
        user.name = "John";
        Debug.Log(user.name);

        //myClass = new NewUser();
        //myClass.health = 100;
        //myClass.name = "ClassJohn";
        //Debug.Log(myClass.name);

        myClass = new NewUser("JohnClass", 100, 1);
        myClass.Id = 2;
        Debug.Log(myClass.Health);

        myClass.Move(2, 2);

    }
}
