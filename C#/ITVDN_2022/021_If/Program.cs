using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _021_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool userAuthorized;// = AuthorizeUser();
            {
                userAuthorized = false;
                string[] loginList = { "Админ", "Иванова", "Петрова", "Сергеева", "Васильева", "Семёнова" };
                string[] passwordList = { "000", "111", "222", "333", "444", "555" };
                int authorizationAttemptCounter = 0;
                const int ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS = 3;
                bool authorizationAttemptAvailable = authorizationAttemptCounter < ALLOWABLE_NUMBER_OF_AUTHORIZATION_ATTEMPTS;
                while (authorizationAttemptAvailable)
                {
                    string login, password; // = InputLoginAndPassword();
                    {
                        Console.Write("Введите логин: ");
                        login = Console.ReadLine();
                        Console.Write("Введите пароль: ");
                        password = Console.ReadLine();
                    }
                    // authorized = TryAuthorizeUser(login, password);
                    {
                        int index = 0;
                        while (index < loginList.Length && index < passwordList.Length)
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
                            else
                            {
                                index++;
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
            }
            // Run (userAthorized);
            {
                while (userAuthorized)
                {
                    string countryCode;
                    decimal quotiti, price;
                    // countryCode, quotiti, price = RunInputUserInterface ()
                    {
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
                    }
                    decimal rate;
                    // rate = CalculatePriceRate (countryCode)
                    {
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
                    }
                    decimal tilePriceWithRate = price * rate;
                    decimal cost = quotiti * tilePriceWithRate;
                    decimal discount; // руб
                    {
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
                        discount = cost / 100 * discountPersentage;
                    }
                    decimal paymentAmount = cost - discount;
                    // RunOutputUserInterface (tilePriceWithRate, cost, discount, paymentAmount)
                    {
                        Console.WriteLine($"Цена с коэффицентом   : {tilePriceWithRate} руб.");
                        Console.WriteLine($"Общая стоимость плитки: {cost} руб.");
                        Console.WriteLine($"Скидка                : {discount} руб.");
                        Console.WriteLine($"Сумма к оплате        : {paymentAmount} руб.");
                    }
                }
            }
        }
    }
}
