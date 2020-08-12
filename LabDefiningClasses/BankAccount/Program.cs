using System;
using System.Collections.Generic;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            
          var accounts = new Dictionary<int, BankAccount>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] tokens = input.Split();

                string command = tokens[0];

                if (command == "Create")
                {
                    int id = int.Parse(tokens[1]);
                    if (accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account already exists");
                    }
                    else
                    {
                        var acc = new BankAccount();
                        acc.Id = id;
                        accounts.Add(id, acc);
                    }
                }
                else if (command == "Deposit")
                {
                    int id = int.Parse(tokens[1]);
                    decimal amount = decimal.Parse(tokens[2]);
                    if (!accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {

                        
                        accounts[id].Deposit(amount);
                        
                    }

                }
                else if (command == "Withdraw")
                {
                    int id = int.Parse(tokens[1]);
                    decimal amount = decimal.Parse(tokens[2]);
                    if (!accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");
                    }
                    else
                    {

                       
                        if (amount > accounts[id].Balance)
                        {
                            Console.WriteLine("Insufficient balance");
                        }
                        else
                        {
                            accounts[id].Withdraw(amount);
                            
                        }

                    }


                }
                else if (command == "Print")
                {
                    int id = int.Parse(tokens[1]);
                    if (!accounts.ContainsKey(id))
                    {
                        Console.WriteLine("Account does not exist");

                    }
                    else
                    {
                        var acc = new BankAccount();

                        Console.WriteLine($"Account ID{id}, " +
                            $"balance {accounts[id].Balance:f2}");
                    }

                }
               
                    
                        

            }
                
        }
    }
}
