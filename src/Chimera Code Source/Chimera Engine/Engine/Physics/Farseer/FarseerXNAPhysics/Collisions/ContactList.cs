using System;
using System.Collections.Generic;
using System.Text;

namespace Chimera.Physics.Farseer.FarseerGames.FarseerXNAPhysics.Collisions
{
    public class ContactList : List<Contact>
    {
        public ContactList(int capacity) : base(capacity)
        { 

        }

        public ContactList(ContactList contactList) : base(contactList) {
        }
    }
}
