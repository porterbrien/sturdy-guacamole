using System.IO.Compression;

class Bird : Pets 
{
    public Bird(string name) : base(name)
    {
        _name = name;
    }

    // public override string displayName()
    // {
    //     return "{name}";
    // }
}