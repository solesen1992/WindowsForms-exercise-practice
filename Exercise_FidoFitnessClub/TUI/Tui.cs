using Exercise_FidoFitnessClub.Controller;
using Exercise_FidoFitnessClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_FidoFitnessClub.TUI
{
    public class Tui
    {
        private RegisterDogController registerDogController;
        private MemberController memberController;

        public Tui()
        {
            memberController = new MemberController();
        }

        public void Start()
        {
            Console.WriteLine("Welcome to the Fido Fitness Club management system");
            bool goOn = true;

            while (goOn)
            {
                Console.Write("Pick one: Register dog (d), show all (a), create (c), read (r) or exit (x): ");
                string inputFromUser = Console.ReadLine().ToLower();
                switch (inputFromUser)
                {
                    case "d":
                        RegisterDog();
                        break;
                    case "c":
                        CreateMember();
                        break;
                    case "r":
                        ReadMember();
                        break;
                    case "a":
                        ShowAllMembers();
                        break;
                    case "x":
                        Exit();
                        goOn = false;
                        break;
                    default:
                        Console.WriteLine($"I don't understand {inputFromUser}, please try again!");
                        break;
                }
            }
        }

        private void ShowAllMembers()
        {
            List<Member> members = memberController.FindAll();
            DisplayMembers(members);
        }

        private void DisplayMembers(List<Member> members)
        {
            Console.WriteLine("Members:");
            foreach (Member member in members)
            {
                Console.WriteLine($"\t{member.Name}\t{member.Email}\t{member.Phone}\tNo. of dogs: {member.Dogs.Count}\towes: {(member.IsFeeDue(2022) ? "yes" : "no")}");
            }
        }

        private void RegisterDog()
        {
            registerDogController = new RegisterDogController();
            if (ReadMemberPartOfRegisterDog() != null)
            {
                bool goOn = true;
                while (goOn)
                {
                    Console.Write("\n  Register a dog? (y/n): ");
                    string keepGoOn = Console.ReadLine();
                    if (keepGoOn.Equals("n", StringComparison.OrdinalIgnoreCase))
                    {
                        goOn = false;
                    }
                    else
                    {
                        Console.Write("     Dog's name: ");
                        string dogName = Console.ReadLine();
                        Console.Write("     Fee year: ");
                        string feeYear = Console.ReadLine();
                        int currentFeeYear = int.Parse(feeYear);
                        Dog dog = registerDogController.RegisterDog(dogName, currentFeeYear);
                        DisplayDog(dog);
                    }
                }
            }
        }

        private void DisplayDog(Dog dog)
        {
            Console.WriteLine("   Dog:");
            Console.WriteLine($"     Name: {dog.Name}");
            Console.WriteLine($"     Fee year: {dog.FeeYear}");
            Console.WriteLine($"    Fee {(dog.IsFeeDue(2022) ? "is" : "is not")} due");
        }

        private void ReadMember()
        {
            Console.WriteLine("Read member:");
            Console.Write("     User email to search for: ");
            string email = Console.ReadLine();
            Member member = memberController.FindByEmail(email);
            DisplayMember("Member", member);
        }

        private Member ReadMemberPartOfRegisterDog()
        {
            Console.WriteLine("Read member:");
            Console.Write("     User email to search for: ");
            string email = Console.ReadLine();
            Member member = registerDogController.FindByEmail(email);
            DisplayMember("Member", member);
            return member;
        }

        private void DisplayMember(string title, Member member)
        {
            Console.WriteLine($"   {title}");
            if (member == null)
            {
                Console.WriteLine("     Not found");
            }
            else
            {
                Console.WriteLine($"     Name: {member.Name}");
                Console.WriteLine($"     Email: {member.Email}");
                Console.WriteLine($"     Phone: {member.Phone}");
                Console.WriteLine($"This member's dogs: ");
                foreach (Dog dog in member.Dogs)
                {
                    DisplayDog(dog);
                }
            }
        }

        private void CreateMember()
        {
            Console.WriteLine("   Register member");
            Console.Write("     Name: ");
            string name = Console.ReadLine();
            Console.Write("     Email: ");
            string email = Console.ReadLine();
            Console.Write("     Phone number: ");
            string phone = Console.ReadLine();
            Member member = memberController.CreateMember(name, email, phone);
            DisplayMember("Member created", member);
        }

        private void Exit()
        {
            Console.WriteLine("Thank you for using the management system. Good bye");
        }
    }
}
