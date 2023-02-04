﻿// Option 3. Authorization system

namespace Uni
{

    class User 
    {
        public string name;
        public string password;
        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }
        public virtual void printName()
        {
            Console.WriteLine(this.name);
        }
        public virtual void printPassword()
        {
            Console.WriteLine("*******");
        }

    }

    class RootUser : User
    {
        public RootUser(string name, string password) : base(name, password)
        {
            
        }

        public override void printName()
        {
            Console.WriteLine("I am Root");
        }
    }

    class SystemNew
    {
        public string version;
        public List<String> users; // Structure which I use for lab
        public SystemNew()
        {
            this.version = "0.1v";
            this.users = new List<string>();
        }
        public void addUser(User user)
        {   
            Console.WriteLine("New user was added:");
            this.users.Add(user.name); // Adding element to list
            user.printName();
            user.printPassword();
        }
        public void removeUser(User user)
        {
            if (this.users.Contains(user.name)) // Does user exist in this list
            {   
                this.users.Remove(user.name); // Removing user from list
                Console.WriteLine("User was removed from list");
            } else {
                Console.WriteLine("There is no this user");
            }
        }
        public void printUsers() 
        {
            Console.WriteLine("Users in system:");
            foreach (string user in this.users) Console.WriteLine(user);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {   
            User user = new User("User", "12345");
            RootUser root_user = new RootUser("Root", "12345");
            SystemNew system_new = new SystemNew();

            Console.WriteLine("System was created: " + system_new.version);

            Console.WriteLine();
            system_new.addUser(user);

            Console.WriteLine();
            system_new.addUser(root_user);

            Console.WriteLine();
            system_new.printUsers();

            Console.WriteLine();
            system_new.removeUser(user);
            system_new.removeUser(user);
        }
    }
}