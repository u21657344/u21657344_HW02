using System.Collections.Generic;
using u21657344_HW02.Models;

namespace u21657344_HW02.ViewModels
{
    public class HomeViewModel
    {
        public int AdoptedPetsCount { get; set; }

        // You can decide whether you want a list of User objects or maybe just a list of strings (names). Here's an example using a list of User objects:
        public List<User> UsersWithAdoptedPets { get; set; }
    }
}

