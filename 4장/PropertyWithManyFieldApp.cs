class PropertyWithManyFieldApp
{
    private string text = "Dept. of Computer Engineering";
    private bool isModified = false;
    public string Text
    {
        get { return text; }
        set { text = value; isModified = true; }
    }
    public void PrintStatus()
    {
        Console.WriteLine("text is \"" + text + "\", and " + (isModified ? "is " : "not ") + "modified");
    }
    public static void Main()
    {
        PropertyWithManyFieldApp obj = new PropertyWithManyFieldApp();
        obj.PrintStatus();
        obj.Text = "Programming Language Lab";
        obj.PrintStatus();
    }
}