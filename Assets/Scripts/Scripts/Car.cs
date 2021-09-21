[System.Serializable] 
public class Car : Transport
{
    public string name;
    public int horsePower;
    public EnginType enginType;

    public Car()
    {
        name = "NULL";
        horsePower = 0;
        enginType = EnginType.Gasoline;
    }

    public Car(string name)
    {
        this.name = name; 
    }
    public Car(string name, int horsePower, EnginType enginType)
    {
        this.name = name;
        this.horsePower = horsePower;
        this.enginType = enginType;
    }

    public string GetInfo()
    {
        return ("Марка" + name +"Лошадей" + horsePower + enginType + weight);
    }


}

public enum EnginType { Elektro, Gasoline, Disel}

