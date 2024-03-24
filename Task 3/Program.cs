class Program
{
    static void Main(string[] args)
    {
        Tree GGFather = new("Прадед");
        Tree GFather = new("Дед");
        Tree Father = new("Отец");
        Tree Father2 = new("Отец2");
        Tree Son = new("Сын");
        Tree GrandSon = new("Внук");

        GGFather.AddChild(GFather);
        GGFather.AddChild(Father);
        GGFather.AddChild(Father2);
        GGFather.AddChild(Son);
        GGFather.AddChild(GrandSon);

        GFather.AddChild(Father);
        GFather.AddChild(Father2);
        GFather.AddChild(Son);
        GFather.AddChild(GrandSon);

        Father.AddChild(Son);
        Father.AddChild(GrandSon);

        Son.AddChild(GrandSon);

        GGFather.ShowFamily();
    }
}