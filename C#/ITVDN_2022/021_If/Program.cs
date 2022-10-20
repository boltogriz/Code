using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _021_If
{
    internal class Program
    {

        static (string userLogin, string userPassword) InputLoginAndPassword()
        {
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string password = Console.ReadLine();
            return (login, password);
        }
        /// <summary>
        /// Авторизует пользователя в системе. Принимает от пользователя логин и пароль.
        /// </summary>
        /// <returns>true - успешная авторизация. false - неуспешная авторизация.</returns>
        static bool AuthorizerUser()
        {
            bool userAuthorized = false;
            string[] loginList = { "Админ", "Иванова", "Петрова", "Сергеева", "Васильева", "Семёнова" };
            string[] passwordList = { "000", "111", "222", "333", "444", "555" };
            int authorizationAttemptCounter = 0;
            const int ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS = 3;
            bool authorizationAttemptAvailable = authorizationAttemptCounter < ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;
            while (authorizationAttemptAvailable)
            {
                var input = InputLoginAndPassword();
                string login = input.userLogin, password = input.userPassword; // = InputLoginAndPassword();
                //(string lgn, string psw) input = InputLoginAndPassword();
                //string login = input.lgn, password = input.psw; // = InputLoginAndPassword();
                //string login = input.Item1, password = input.Item2; // = InputLoginAndPassword();

                // authorized = TryAuthorizeUser(login, password);
                {
                    for (int index = 0; index < loginList.Length && index < passwordList.Length; index++)
                    {
                        bool loginMatched, passwordMatched; // = MatchLoginAndPassword()
                        {
                            string loginByCurrentIndex = loginList[index];
                            loginMatched = loginByCurrentIndex == login;
                            string passwordByCurrentIndex = passwordList[index];
                            passwordMatched = passwordByCurrentIndex == password;
                        }
                        if (loginMatched && passwordMatched)
                        {
                            userAuthorized = true;
                            break;
                        }
                    }
                }
                if (userAuthorized)
                {
                    Console.WriteLine("Вы успешно авторизованы.");
                    break;
                }
                else
                {
                    Console.WriteLine("Логин или пароль введены не правильно.");
                    authorizationAttemptAvailable = ++authorizationAttemptCounter < ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;
                    if (authorizationAttemptAvailable)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Вы исчерпали количество попыток авторизации. Обратитесь к администратору");
                        break;
                    }
                }
            }
            return userAuthorized;
        }
        /// <summary>
        /// Выводит информацию пользователю о совершенной покупке
        /// </summary>
        /// <param name="tilePriceWithRate">Цена с коэффициентом</param>
        /// <param name="cost">Общая стоимость плитки</param>
        /// <param name="discount">Скидка</param>
        /// <param name="paymentAmount">Сумма к оплате</param>
        static void RunOutputUserInterFace(decimal tilePriceWithRate,
                                           decimal cost,
                                           decimal discount,
                                           decimal paymentAmount)
        {
            Console.WriteLine($"Цена с коэффицентом   : {tilePriceWithRate:C2}");
            Console.WriteLine($"Общая стоимость плитки: {cost:C2}");
            Console.WriteLine($"Скидка                : {discount:C2}");
            Console.WriteLine($"Сумма к оплате        : {paymentAmount:C2}");
        }
        /// <summary>
        /// Возвращает коэффицент скидки для указанной страны
        /// </summary>
        /// <param name="countryCode">Телефонный код страны</param>
        /// <returns>Коээфицент скидки</returns>
        static decimal CalculatePriceRate(string countryCode)
        {
            decimal rate;
            const string UPPERCASE_ENGLISH_LETTER_K = "K";
            const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                         GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K, KYRGYZSTAN_CODE = "996",
                         LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                         RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992";
            switch (countryCode)
            {
                case AZERBAIJAN_CODE:
                    {
                        const decimal AZERBAIJAN_RATE = 1.07m;
                        rate = AZERBAIJAN_RATE;
                        break;
                    }
                case (ARMENIA_CODE):
                    {
                        const decimal ARMENIA_RATE = .95m;
                        rate = ARMENIA_RATE;
                        break;
                    }
                case (BELARUS_CODE):
                    {
                        const decimal BELARUS_RATE = 1m;
                        rate = BELARUS_RATE;
                        break;
                    }
                case (GEORGIA_CODE):
                    {
                        const decimal GEORGIA_RATE = 0.94m;
                        rate = GEORGIA_RATE;
                        break;
                    }
                case (KAZAKHSTAN_CODE):
                    {
                        const decimal KAZAKHSTAN_RATE = 0.79m;
                        rate = KAZAKHSTAN_RATE;
                        break;
                    }
                case (KYRGYZSTAN_CODE):
                    {
                        const decimal KYRGYZSTAN__RATE = 0.83m;
                        rate = KYRGYZSTAN__RATE;
                        break;
                    }
                case (LATVIA_CODE):
                    {
                        const decimal LATVIA_RATE = 1.12m;
                        rate = LATVIA_RATE;
                        break;
                    }
                case (LITHUANIA_CODE):
                    {
                        const decimal LITHUANIA_RATE = 1.12m;
                        rate = LITHUANIA_RATE;
                        break;
                    }
                case (MOLDOVA_CODE):
                    {
                        const decimal MOLDOVA_RATE = 1.12m;
                        rate = MOLDOVA_RATE;
                        break;
                    }
                case (RUSSIA_CODE):
                    {
                        const decimal RUSSIA_RATE = 1m;
                        rate = RUSSIA_RATE;
                        break;
                    }
                case (TAJIKISTAN_CODE):
                    {
                        const decimal TAJIKISTAN_RATE = 1.8m;
                        rate = TAJIKISTAN_RATE;
                        break;
                    }
                default:
                    {
                        rate = 0;
                        break;
                    }
            }
            return rate;
        }
        /// <summary>
        /// Выводит и получает код страны. Принимает значение количество плитки и формирует цену
        /// </summary>
        /// <returns>Код страны, количество плитки, цену плитки</returns>
        static (string countryCode, decimal quotiti, decimal price) RunInputUserInterface()
        {
            string countryCode;
            decimal quotiti, price;
            Console.WriteLine("Нажмите Enter, для начала обслуживания нового клиента");
            Console.ReadKey();
            const string COUNTRY_CODES =
                "======================================================\n" +
                "Азербайджан (994) | Киргизяи (996) | Таджикистан (992)\n" +
                "Армения     (374) | Латвия   (371) | Туркмения   (993)\n" +
                "Беларусь    (375) | Литва    (370) | Узбекистан  (998)\n" +
                "Грузия      (995) | Молдова  (373) | Украина     (380)\n" +
                "Казахстан  (007K) | Россия   (007) | Эстония     (372)\n" +
                "------------------------------------------------------";
            Console.WriteLine(COUNTRY_CODES);
            // countryCode = ProcessCountryCode (CountryCode);
            {
                bool countryCodeIsCorrect;
                do
                {
                    Console.Write("Телефонный код страны: ");
                    countryCode = Console.ReadLine();
                    // countryCode = DetectKazakhstanCode (countryCode)
                    {
                        const string KAZAKHSTAN_CODE = "007";
                        const string LOWERCASE_ENGLISH_LETTER_k = "k", UPPERCASE_RUSSIAN_LETTER_K = "К",
                                     LOWERCASE_RUSSIAN_LETTER_k = "к";
                        bool countryCodeIsKazakhstanCodeAndAnyLetterK =
                                    countryCode == (KAZAKHSTAN_CODE + LOWERCASE_ENGLISH_LETTER_k) ||
                                    countryCode == (KAZAKHSTAN_CODE + UPPERCASE_RUSSIAN_LETTER_K) ||
                                    countryCode == (KAZAKHSTAN_CODE + LOWERCASE_RUSSIAN_LETTER_k);
                        if (countryCodeIsKazakhstanCodeAndAnyLetterK)
                        {
                            const string UPPERCASE_ENGLISH_LETTER_K = "K";
                            countryCode = KAZAKHSTAN_CODE + UPPERCASE_ENGLISH_LETTER_K;
                        }
                    }
                    // countyrCodeIsCorrect = CheckCountryCode (coutnryCode)
                    {
                        const string UPPERCASE_ENGLISH_LETTER_K = "K";
                        const string AZERBAIJAN_CODE = "994", ARMENIA_CODE = "374", BELARUS_CODE = "375",
                                     GEORGIA_CODE = "995", KAZAKHSTAN_CODE = "007" + UPPERCASE_ENGLISH_LETTER_K, KYRGYZSTAN_CODE = "996",
                                     LATVIA_CODE = "371", LITHUANIA_CODE = "370", MOLDOVA_CODE = "373",
                                     RUSSIA_CODE = "007", TAJIKISTAN_CODE = "992";
                        switch (countryCode)
                        {
                            case AZERBAIJAN_CODE:
                            case ARMENIA_CODE:
                            case BELARUS_CODE:
                            case GEORGIA_CODE:
                            case KAZAKHSTAN_CODE:
                            case KYRGYZSTAN_CODE:
                            case LATVIA_CODE:
                            case LITHUANIA_CODE:
                            case MOLDOVA_CODE:
                            case RUSSIA_CODE:
                            case TAJIKISTAN_CODE:
                                {
                                    countryCodeIsCorrect = true;
                                    break;
                                }
                            default:
                                {
                                    countryCodeIsCorrect = false;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"Вы ввели несуществующий код: {countryCode}!");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    break;
                                }
                        }
                    }
                }
                while (countryCodeIsCorrect == false);
            }
            Console.Write("Количество плитки: ");
            string stringQuontiti = Console.ReadLine();
            quotiti = Convert.ToUInt32(stringQuontiti);

            Console.Write("Цена за 1 м.кв. плитки: ");
            string stringPrice = Console.ReadLine();
            price = Convert.ToUInt32(stringPrice);
            return (countryCode, quotiti, price);
        }
        /// <summary>
        /// Расчитывает скидку
        /// </summary>
        /// <param name="cost">Стоимость плитки</param>
        /// <param name="quotiti">Количество плитки</param>
        /// <returns>Скидка</returns>
        static decimal GetDiscount(decimal cost, decimal quotiti)
        {
            decimal discount;
            decimal discountPersentage;
            {
                bool discount20PctAvailabe, discoun50PctAvailable;
                {
                    const decimal MIN_TILE_QTY_FOR_DISCOUNT_20_PCT = 500,
                                  MIN_TILE_QTY_FOR_DISCOUNT_50_PCT = 1000;// м.кв.
                    discount20PctAvailabe = quotiti >= MIN_TILE_QTY_FOR_DISCOUNT_20_PCT &&
                                            quotiti < MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                    discoun50PctAvailable = quotiti >= MIN_TILE_QTY_FOR_DISCOUNT_50_PCT;
                }
                if (discount20PctAvailabe)
                {
                    discountPersentage = 20; // %
                }
                else if (discoun50PctAvailable)
                {
                    discountPersentage = 50;
                }
                else
                {
                    discountPersentage = 0;
                }
            }
            return discount = cost / 100 * discountPersentage;
        }
        /// <summary>
        /// Запуск основого процесса общета плитки в консоле в цикле
        /// </summary>
        /// <param name="userAuthorized">Авторизация</param>
        static void Run(bool userAuthorized)
        {
            while (userAuthorized)
            {
                var inputRun = RunInputUserInterface();
                string countryCode = inputRun.countryCode;
                decimal quotiti = inputRun.quotiti, price = inputRun.price;
                decimal rate = CalculatePriceRate(countryCode);
                decimal tilePriceWithRate = price * rate;
                decimal cost = quotiti * tilePriceWithRate;
                decimal discount = GetDiscount(cost, quotiti); // руб
                decimal paymentAmount = cost - discount;
                RunOutputUserInterFace(tilePriceWithRate, cost, discount, paymentAmount);
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            bool userAuthorized = AuthorizerUser();
            Run(userAuthorized);
        }
    }
}
