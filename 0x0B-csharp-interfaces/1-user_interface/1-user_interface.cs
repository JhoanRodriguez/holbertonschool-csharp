using System;

/// <summary> Interactive interface </summary>
interface IInteractive
{
    void Interact();
}

/// <summary> Breakable Interface </summary>
interface IBreakable
{
   int durability {get; set;}
   void Break();
}

/// <summary> Collectable Interface </summary>
interface ICollectable
{
    bool isCollected {get; set;}
    void Collect();
}

/// <summary> Class that inherits from Base class and all interfaces </summary>
class TestObject : IInteractive, IBreakable, ICollectable
{
    public int durability {get; set;}
    public bool isCollected {get; set;}

    public void Interact(){

    }

    public void Break(){

    }

    puiblic void Collect(){
        
    }

}