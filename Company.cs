namespace pt3;

[Serializable]
public class Company
{
    private String name;
    private String country;
    private String direction;
    private int staffs;
    private long money;

    public Company()
    {
        
    }

    public Company(string name, string country, string direction, int staffs, long money)
    {
        this.name = name;
        this.country = country;
        this.direction = direction;
        this.staffs = staffs;
        this.money = money;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Country
    {
        get => country;
        set => country = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Direction
    {
        get => direction;
        set => direction = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Staffs
    {
        get => staffs;
        set => staffs = value;
    }

    public long Money
    {
        get => money;
        set => money = value;
    }
    
    public override string ToString()
    {
        return "Name: " + name + "\n"
               + "Country: " + country + "\n"
               + "Direction: " + direction + "\n"
               + "Staff:" + staffs + "\n"
               + "Money: " + money + "\n";
    }
}