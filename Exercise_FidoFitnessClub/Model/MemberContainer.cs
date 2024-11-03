using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The MemberCont class is a singleton that manages a collection of Member objects.
 * 
 * The class is responsible for managing a list of members and enforces uniqueness by email.
 * It provides methods to add members, find members by email, and retrieve all members.
 * 
 * Since it's a singleton, only one instance of MemberCont will exist during the application's lifetime, 
 * making it useful when you want a centralized manager for members.
 * 
 * This design is helpful for applications where you need to maintain a shared list of members, 
 * such as in user management systems or membership databases.
 */

namespace Exercise_FidoFitnessClub.Model
{
    public class MemberContainer
    {
        private static MemberContainer _instance;
        private List<Member> members;

        /*
         * The class implements the singleton pattern, which ensures that only one instance of the class can be created.
         * The MemberCont class has a private static field _instance that holds this single instance.
         * The property Instance provides access to the single instance, initializing it only when it's accessed for the first time (lazy initialization).
         */
        public static MemberContainer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MemberContainer();
                }
                return _instance;
            }
        }

        /*The class contains a private list called members(List<Member>) that stores all the Member objects.
         * This list is initialized in the private constructor, which is called only once when the instance is created.
         */
        private MemberContainer()
        {
            members = new List<Member>();
        }

        /*
         * The AddMember(Member m) method adds a Member object to the members list, but only if there isn't already a Member with the same email.
         * It first calls FindByEmail to check if a member with the same email exists.
         * If no member with the given email exists, it adds the new member to the list.
         * If a member with the same email already exists, it throws an ArgumentException indicating the email is already in use.
         */
        public void AddMember(Member member)
        {
            if (FindByEmail(member.Email) == null)
            {
                members.Add(member);
            }
            else
            {
                throw new ArgumentException("A member with the same email already exists.");
            }
        }

        /*
         * The FindByEmail(string email) method searches for a Member in the members list by matching the email.
         * It iterates through the list and compares each member's email with the given email, ignoring case differences (StringComparison.OrdinalIgnoreCase).
         * If a matching Member is found, it returns that member. If not, it returns null.
         */
        public Member FindByEmail(string email)
        {
            return members.FirstOrDefault(m => m.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            /*foreach (var member in members)
            {
                if (member.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    return member;
                }
            }

            return null; // If no match is found, return null*/

            /*Member result = null;
            for (int i = 0; i < members.Count && result == null; i++) {
                if (members[i].Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    result = members[i];
                }
            }
            return result;*/
        }

        /*
         * The FindAll() method returns a copy of the entire members list as a new list. 
         * This protects the internal list from being modified externally.
         */
        public List<Member> FindAll()
        {
            return new List<Member>(members);
        }

        /*
         * The Count property returns the total number of members in the container.
         * This can be useful for displaying statistics or managing membership limits.
         */
        public int Count
        {
            get { return members.Count; }
        }
    }
}
