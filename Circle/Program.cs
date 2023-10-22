namespace Circle        // Niklas Sjödin NET23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCircle = new Circle(5);       // Nya objekt
            var myCircle2 = new Circle(6);

            double cArea = myCircle.GetArea();     // Uträkningen av metoden area på en cirkel
            double cArea2 = myCircle2.GetArea();

            double cCircumference = myCircle.GetCircumference();        // Uträkningen av metoden omkrets på en cirkel
            double cCircumference2 = myCircle2.GetCircumference();

            double cVolume = myCircle.GetVolume();      // Uträkningen av metoden volym på en cirkel
            double cVolume2 = myCircle2.GetVolume();

            var myTriangle = new Triangle(10, 5, 5);       // Nya objekt
            var myTriangle2 = new Triangle(25, 12, 3);

            double tArea = myTriangle.GetTArea();     // Uträkning av metoden area på en triangel
            double tArea2 = myTriangle2.GetTArea();

            double tCircumference = myTriangle.GetTCircumference();       // Uträkning av metoden omkrets på en triangel
            double tCircumference2 = myTriangle2.GetTCircumference();

            double tVolume = myTriangle.GetTVolume();     // Uträkning på metoden volym på en triangel
            double tVolume2 = myTriangle2.GetTVolume();

            Console.WriteLine("Uträkning på Arean: ");
            Console.WriteLine($"Arean på en cirkel med 5 i radie är: {cArea}, avrundat till " + Math.Round(cArea, 1) + ".");
            Console.WriteLine($"Arean på en cirkel med 6 i radie är: {cArea2}, avrundat till " + Math.Round(cArea2, 1) + ".\n");

            Console.WriteLine("Uträkning på Omkretsen: ");
            Console.WriteLine($"Omkretsen på en sfär med 5 i radie är: {cCircumference}, avrundat till " + Math.Round(cCircumference, 1) + ".");  
            Console.WriteLine($"Omkretsen på en sfär med 6 i radie är: {cCircumference2}, avrundat till " + Math.Round(cCircumference2, 1) + ".\n");

            Console.WriteLine("Uträkning på Volymen: ");
            Console.WriteLine($"Volymen på en sfär med 5 i radie är: {cVolume}, avrundat till " + Math.Round(cVolume, 1) + ".");
            Console.WriteLine($"Volymen på en sfär med 6 i radie är: {cVolume2}, avrundat till " + Math.Round(cVolume2, 1) + ".\n");

            Console.WriteLine("Uträkning på Arean: ");
            Console.WriteLine($"Arean på en triangel med basen 10 och höjden 5 är: {tArea}");
            Console.WriteLine($"Arean på en triangel med basen 25 och höjden 12 är: {tArea2}\n");

            Console.WriteLine("Uträkning på Omkretsen: ");
            Console.WriteLine($"Omkretsen på en triangel med basen 10, höjden 5 och hypotenusan 5 är: {tCircumference}");
            Console.WriteLine($"Omkretsen på en triangel med basen 25, höjden 12 och hypotenusan 3 är: {tCircumference2}\n");

            Console.WriteLine("Uträkning på Volymen: ");
            Console.WriteLine($"Volymen på en triangel med basen 10, höjden 5 och hypotenusan 5 är: {tVolume}");
            Console.WriteLine($"Volymen på en triangel med basen 25, höjden 12 och hypotenusan 3 är: {tVolume2}");
        }
    }
}