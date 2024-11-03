using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_FidoFitnessClub.Model
{
    public class Member
    {
        // Properties
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Dog> Dogs { get; set; }

        // Constructor
        public Member(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
            Dogs = new List<Dog>();  // Initialize the list
        }

        // Add dog to member
        public void AddDog(Dog dog)
        {
            if (dog != null)
            {
                Dogs.Add(dog);
            }
        }

        /**
        * Retrieve the dog objects, this member has. The returned variable does not
        * allow direct modification of the internal structure of Member object.
        * @return a List containing the member's dogs
        */
        public List<Dog> GetDogs()
        {
            return new List<Dog>(Dogs); // Return a new list containing the same elements
        }

        // Method to remove a Dog
        public void RemoveDog(Dog dog)
        {
            Dogs.Remove(dog);
        }

        /**
         * Count how many dogs have unpaid fees for a given year.
        * Returns the number of dogs for which the given Member has not paid membership fee
        * @param year is the year for which we want to check for
        * @return a number representing the number of dogs fee is due for
        */
        public int UnpaidCount(int year)
        {
            int result = 0;
            foreach (Dog dog in Dogs)
            {
                if (dog.IsFeeDue(year))
                {
                    result++;
                }
            }
            return result;
        }

        /**
         * Return a list of dogs with unpaid fees for a given year
         * Returns the dogs the given member has not paid the fee for. The list is empty if
         * the member doesn't owe money to the club.
         * @param year the year we want to check for
         * @return a list of dogs fee is due for for the given year
        */
        public List<Dog> UnpaidList(int year)
        {
            List<Dog> result = new List<Dog>();
            foreach (Dog dog in Dogs)
            {
                if (dog.IsFeeDue(year))
                {
                    result.Add(dog);
                }
            }
            return result;
        }

        /**
         * Check if any fees are due for the member's dogs
         * Any unpaid fees?
         * @param year the year we check for
         * @return <code>true</code> if the member owes money, <code>false</code> otherwise.
         */
        public bool IsFeeDue(int year)
        {
            foreach (Dog dog in Dogs)
            {
                if (dog.IsFeeDue(year))
                {
                    return true;
                }
            }
            return false;
        }

        // Find dog by name
        public Dog FindDogByName(string name)
        {
            foreach (Dog dog in Dogs)
            {
                if (dog.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return dog;
                }
            }
            return null; // Return null if no matching dog is found
        }

        // Override ToString method
        public override string ToString()
        {
            return $"Member [Name={Name}, Phone={Phone}, Email={Email}, Dogs={string.Join(", ", Dogs)}]";
        }
    }
}
