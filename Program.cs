using System;

namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(":::::::Welcome To Address Book Program::::::::::::");
            AddressBook addressBook = new AddressBook();
            addressBook.AddToDataTable();
        }
    }
}
