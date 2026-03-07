using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal class UserAccount
    {
    // Приватные поля (скрытые данные)
    private string username;
        private string password;
        private decimal balance;
        // Свойство только для чтения
        public string Username
        {
            get { return username; }
        }
        // Конструктор
        public UserAccount(string username, string password, decimal balance)
        {
            this.username = username;
            this.password = password;
            this.balance = balance;
        }
        // Метод проверки пароля
        public bool Login(string inputPassword)
        {
            return password == inputPassword;
        }
        // Метод пополнения баланса
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Balance updated: {balance}");
            }
        }
        // Метод получения баланса
        public decimal GetBalance()
        {
            return balance;
        }
    }
}