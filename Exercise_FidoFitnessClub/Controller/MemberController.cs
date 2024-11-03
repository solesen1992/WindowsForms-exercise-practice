using Exercise_FidoFitnessClub.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class abstracts the details of how members are stored and retrieved, allowing the rest 
 * of the application to interact with members in a more straightforward way without needing 
 * to know how they are managed internally. It promotes separation of concerns, ensuring 
 * the business logic remains clean and focused on the application's functionality rather than data access.
 */

namespace Exercise_FidoFitnessClub.Controller
{
    public class MemberController
    {
        /*
         * The FindByEmail method in MemberController serves as a high-level function 
         * that retrieves a specific Member from the MemberContainer (which holds all members) 
         * based on the provided email address. It abstracts the internal workings of the MemberContainer, 
         * so the rest of the application can simply call this method to find members by email 
         * without worrying about how the data is stored or managed.
         */
        public Member FindByEmail(string email) // 1.1
        {
            MemberContainer memberContainer = MemberContainer.Instance; // Accessing singleton instance correctly
            Member member = memberContainer.FindByEmail(email); // 1.1.1: ...
            return member;
        }

        /*
         * The CreateMember method creates a new Member object with the provided name, email, and phone number. 
         * It then adds this Member to the MemberContainer (a centralized list managed by the singleton). 
         * The method enforces the uniqueness of members based on their email. Finally, it returns the newly 
         * created Member object so that the calling code can further use or display the new member's details.
         * 
         * This method simplifies member creation by encapsulating the logic for creating and registering a new member within the MemberController.
         */
        public Member CreateMember(string name, string email, string phone)
        {
            Member member = new Member(name, email, phone);
            MemberContainer.Instance.AddMember(member); // Using 'Instance' to access the singleton
            return member;
        }

        /*
         * The FindAll method in the MemberController acts as a simple wrapper around the 
         * MemberContainer's FindAll() method. Its purpose is to retrieve a list of all members 
         * that have been registered in the system. By calling MemberContainer.Instance.FindAll(), 
         * it returns a list of all Member objects from the singleton MemberContainer, ensuring 
         * that the external code doesn't modify the internal collection directly.
         */
        public List<Member> FindAll()
        {
            return MemberContainer.Instance.FindAll(); // Using 'Instance' to get all members
        }
    }
}
