using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator.Overloading
{
    /// <summary>
    /// Задание будет базироваться на примере в этом уроке. Необходимо реализовать второй вариант сложения денег – чтобы
    /// можно было суммировать деньги в разных валютах. Для этого создайте отдельный класс, который будет предоставлять механизм
    /// конвертации денег по заданному курсу. Кроме этого, перегрузите для класса Money оператор сравнения «==»
    /// (при перегрузке данного оператора, обязательной является и перегрузка противоположного ему оператора «!=»).
    /// </summary>
    public class Money
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public Money(decimal amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public static Money operator +(Money money1, Money money2)
        {
            if (money1.Currency != money2.Currency)
            {
                throw new InvalidOperationException("Cannot add money with different currencies.");
            }

            return new Money(money1.Amount + money2.Amount, money1.Currency);
        }

        public static bool operator ==(Money money1, Money money2)
        {
            return money1.Amount == money2.Amount && money1.Currency == money2.Currency;
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return !(money1 == money2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Money money)
            {
                return this == money;
            }

            return false;
        }

    }
    public class CurrencyConverter
    {
        public decimal ExchangeRate(string sourceCurrency, string targetCurrency, decimal rate)
        {
            if (sourceCurrency == targetCurrency)
            {
                return 1.0M;
            }

            // Здесь вы можете добавить логику для получения реального курса обмена валют из внешних источников.

            return rate;
        }

        public Money Convert(Money sourceMoney, string targetCurrency, decimal rate)
        {
            decimal exchangeRate = ExchangeRate(sourceMoney.Currency, targetCurrency, rate);
            decimal convertedAmount = sourceMoney.Amount * exchangeRate;

            return new Money(convertedAmount, targetCurrency);
        }
    }

}
