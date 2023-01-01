namespace webapi_net6_options_pattern;

public class MySettings
{
    public string Name { get; set; }
    public string LastName { get; set; }
    public Action Action { get; set; }

}
public class Action {
  public string Attribute { get; set; }
  public string Value { get; set; }
}
