using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// тип счета
    /// </summary>
    enum BalanceType
    {
        credit,
        debit
    }
    class Account
    {
        private static int startId = 0;
        private int id;
        private decimal balance;
        private BalanceType accountType;

        /// <summary>
        /// номер счета
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        /// <summary>
        /// баланс
        /// </summary>
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
        }

        /// <summary>
        /// тип счета
        /// </summary>
        public BalanceType AccountType
        {
            get
            {
                return this.accountType;
            }
        }

        public Account(): this(BalanceType.debit, 0){}

        public Account(BalanceType type) : this(type, 0) { }

        public Account(decimal balance) : this(BalanceType.debit, balance) { }


        public Account(BalanceType type, decimal balance)
        {
            if (StartBalanceValidation(balance))
            {
                this.balance = balance;
            } else
            {
                this.balance = 0;
            }

            this.accountType = type;
            this.id = CreateAcountNumber();

        }

        private int CreateAcountNumber()
        {
            startId = startId + 1;
            return startId;
        }

        public bool Added(decimal add)
        {
            if (!CanAdd(add)) { return false; }

            this.balance = this.balance + add;

            return true;
        }

        public bool Withdrawed(decimal withdraw)
        {
            if (!CanWithdraw(withdraw)) { return false; }

            this.balance = this.balance - withdraw;

            return true;
        }

        //проверка что дс можно положить на счет
        //проверяется корректность введенной суммы, лимиты и т.д.
        private bool CanAdd(decimal add)
        {
            if (add < 0)
            {
                return false;
            }

            return true;
        }

        //проверка что дс можно снять со счета
        //проверяется корректность введенной суммы, лимиты и т.д.
        private bool CanWithdraw(decimal withdraw)
        {
            if(withdraw < 0)
            {
                return false;
            }
            if((this.balance - withdraw) < 0)
            {
                return false;
            }

            return true;
        }

        //проверка что стартовый баланс при создании класса соответствует требованиям
        private bool StartBalanceValidation(decimal balance)
        {
            if(balance < 0) { return false; }

            return true;
        }

        public static bool operator ==(Account a1, Account a2)
        {
            return Compare(a1, a2);
        }

        public static bool operator !=(Account a1, Account a2)
        {
            return !Compare(a1, a2);
        }

        public override bool Equals(object obj)
        {
            try
            {
                Account account = (Account)obj;
                return Compare(this, account);
            }
            catch
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, accountType);
        }

        public override string ToString()
        {
            return $"Id: {Id}\nAccount Type: {AccountType}\nBalance: {Balance}";
        }

        private static bool Compare(Account a1, Account a2)
        {
            if(a1 == null || a2 == null)
            {
                return false;
            }

            if(a1.id != a2.id)
            {
                return false;
            }

            if(a1.balance != a2.balance)
            {
                return false;
            }

            if(a1.accountType != a2.accountType)
            {
                return false;
            }

            return true;
        }

    }
}
