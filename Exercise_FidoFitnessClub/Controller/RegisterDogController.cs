using Exercise_FidoFitnessClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * The RegisterDogController class is responsible for managing the registration 
 * and updating of dogs for a specific member in the system.
 * 
 * It works by interacting with the Member and Dog classes, handling 
 * the association of dogs to members and updating dog information when necessary.
 * 
 * The class provides three main functionalities:
 * 1. Finding a member by their email.
 * 2. Registering a new dog for the current member.
 * 3. Updating the details of an existing dog for the current member.
 * 
 * Key components:
 * - _currentMember: This private field holds a reference to the current member 
 *   who is interacting with the system. It is used throughout the class 
 *   to manage the member's dogs.
 * 
 * Usage:
 * - The user of this class would first find a member by email using the 
 *   `FindByEmail` method, which sets the current member.
 * - After finding the member, the user can register a new dog or update 
 *   an existing dog's details for that member.
 */

namespace Exercise_FidoFitnessClub.Controller
{
    public class RegisterDogController
    {
        private Member _currentMember;

        /*
         * Purpose: This method is used to find a Member object by their email address.
         * 
         * How it works:
         * It creates an instance of MemberCtrl, which manages member-related operations.
         * It calls the FindByEmail method from MemberCtrl to search for a member by their email.
         * The result (a Member object) is stored in the private _currentMember field and returned.
         * 
         * Outcome: If a member with the given email is found, it returns the Member object.
         */
        public Member FindByEmail(String email)
        {
            MemberController memberController = new MemberController();
            _currentMember = memberController.FindByEmail(email);
            if (_currentMember == null)
            {
                throw new ArgumentException("Member not found.");
            }
            return _currentMember;

            /*MemberController memberController = new MemberController();
            _currentMember = memberController.FindByEmail(email);
            return _currentMember;*/
        }

        /*
         * Purpose: This method is used to register a new dog for the current member (_currMember).
         * 
         * How it works:
         * It creates a new Dog object with the provided dogName and feeYear (representing the year the registration fee is paid for).
         * It adds the newly created Dog object to the current member's list of dogs using _currMember.AddDog(dog).
         * Finally, it returns the Dog object that was just created and registered.
         * 
         * Outcome: A new dog is associated with the current member, and the details of the dog are returned.
         */
        public Dog RegisterDog(String dogName, int feeYear)
        {
            if (_currentMember == null)
            {
                throw new InvalidOperationException("No member is set. Find a member first.");
            }

            Dog newDog = new Dog(dogName, feeYear);
            _currentMember.Dogs.Add(newDog);
            return newDog;

            /*Dog dog = new Dog(dogName, feeYear);
            _currentMember.AddDog(dog);
            return dog;*/
        }

        /*
         * Purpose: This method is used to update the information of an existing dog for the current member.
         * 
         * How it works:
         * It searches for a dog within the current member's collection by the dog's existing name 
         * (oldName) using _currentMember.FindDogByName(oldName).
         * Once the Dog object is found, it updates the dog's name to newName and updates the dog's registration year to year.
         * 
         * Outcome: The dog's name and registration year are updated in the system.
         */
        public void UpdateDog(String oldName, String newName, int year)
        {
            Dog dog = _currentMember.FindDogByName(oldName);

            // Check if the dog was found
            if (dog == null)
            {
                Console.WriteLine($"Dog with name '{oldName}' not found.");
                return; // Or throw an exception, depending on your error handling strategy
            }

            // Update the dog's information
            dog.Name = newName;
            dog.FeeYear = year;

            Console.WriteLine($"Dog updated: {dog}");
            Console.WriteLine($"Dog updated: Name='{dog.Name}', FeeYear={dog.FeeYear}");

            /*Dog dog = _currentMember.FindDogByName(oldName);
            dog.Name = newName;
            dog.FeeYear = year;*/
        }
    }
}
