using System.Xml.Serialization;

namespace pt3;

public class Work
{
    private XmlSerializer xmlSerializer = new(typeof(Company));

    public void save(Company o)
    {
        using FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate);
        xmlSerializer.Serialize(fs, o);
    }

    public Company? get()
    {
        using FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate);
        return xmlSerializer.Deserialize(fs) as Company;
    }
}