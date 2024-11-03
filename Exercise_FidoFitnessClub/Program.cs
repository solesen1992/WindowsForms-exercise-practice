using Exercise_FidoFitnessClub.Controller;
using Exercise_FidoFitnessClub.Model;
using Exercise_FidoFitnessClub.TUI;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteTestData();
            Tui tui = new Tui();
            tui.Start();
            Console.WriteLine("Hello");
        }

        private static void WriteTestData()
        {
            MemberController memberController = new MemberController();

            // Create a new member
            Member newMember = memberController.CreateMember("John Doe", "123-456-7890", "john@example.com");
            Console.WriteLine($"Created member: {newMember}");
            Member newMember2 = memberController.CreateMember("Jane", "77777777", "jane@example.com");
            Console.WriteLine($"Created member: {newMember2}");
            Member newMember3 = memberController.CreateMember("Janice", "88888888", "janice@example.com");
            Console.WriteLine($"Created member: {newMember3}");

            // Register a dog for the new member
            RegisterDogController dogController = new RegisterDogController();

            dogController.FindByEmail("john@example.com");
            Dog newDog = dogController.RegisterDog("Fido", 2024);
            Console.WriteLine($"Registered dog: {newDog}");

            dogController.FindByEmail("john@example.com");
            Dog newDog4 = dogController.RegisterDog("Paw", 2021);
            Console.WriteLine($"Registered dog: {newDog4}");

            dogController.FindByEmail("jane@example.com");
            Dog newDog2 = dogController.RegisterDog("Rolf", 2022);
            Console.WriteLine($"Registered dog: {newDog2}");

            dogController.FindByEmail("janice@example.com");
            Dog newDog3 = dogController.RegisterDog("Vaks", 2023);
            Console.WriteLine($"Registered dog: {newDog3}");

            // Update dog information
            dogController.UpdateDog("Fido", "Buddy", 2025);
            Console.WriteLine($"Dog update attempted for Fido.");
            Console.WriteLine($"Updated dog: {newDog}");
        }
    }
}