using UnityEngine;

public class Person : MonoBehaviour
{
    public string Name = "PersonName";
    public int Age = 18;
    
    protected string Gender = "Male";
    
    private string Nationality = "Ukrainian";
    
    public void ShowName()
    {
        Debug.Log("Name: " + Name);
    }
    
    public virtual void ShowInfo()
    {
        Debug.Log($"Name: {Name}\n Gender: {Gender}\n Nationality: {Nationality}");
        ShowAge();
    }
    
    protected virtual void ShowAge()
    {
        Debug.Log("Age: " + Age);
    }

    private void Smth()
    {
        Debug.Log("Private field!");
    }
}
