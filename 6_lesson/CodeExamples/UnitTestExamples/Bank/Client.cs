using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Client
    {
        private string _surname;
        private int _sum;

        public string Name { get; set; }
        public string Surname
        {
            get { return _surname; }
            set { throw new ClientException("Not possible to set surname"); }
        }

        public void SetSurname(string surname)
        {
            if (!string.IsNullOrEmpty(surname))
            {
                _surname = surname;
            }
        }

        public string GetFullName(string name, string surname)
        {
            return $"{name} {surname}";
        }

        public int CurrentSum
        {
            get { return _sum; }
        }

        public void Put(int sum)
        {
            _sum += sum; //_sum=_sum+sum
        }

        public void Withdraw(int sum)
        {
            if (sum < 0)
            {
                throw new AccountException($"Amount could not be negative");
            }

            if (sum <= _sum)
            {
                _sum -= sum; //_sum = _sum-sum
            }
            else
            {
                throw new AccountException($"There is not enough money on your bank account");
            }
        }
    }
}
