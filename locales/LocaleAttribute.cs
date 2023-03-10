namespace NAIBot.locales;

[AttributeUsage(AttributeTargets.Property)]
public class LocaleAttribute : Attribute
{
    public string Key { get; set; }

    public LocaleAttribute(string key) => Key = key;
}