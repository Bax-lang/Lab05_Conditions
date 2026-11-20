// // // // // // // // // Console.Write("Введите число: ");
// // // // // // // // // int number = int.Parse(Console.ReadLine());
// // // // // // // // // if (number > 0) {
// // // // // // // // //     Console.WriteLine("Число положительное.");
// // // // // // // // // }
// // // // // // // // // else if (number < 0) {
// // // // // // // // //     Console.WriteLine("Число отрицательное.");
// // // // // // // // // }
// // // // // // // // // else {
// // // // // // // // //     Console.WriteLine("Число равно нулю.");
// // // // // // // // // }

// // // // // // // // // Console.Write("Введите балл (0-100): ");
// // // // // // // // // int score = int.Parse(Console.ReadLine());
// // // // // // // // // if (score >= 91) {
// // // // // // // // //     Console.WriteLine("Оценка: Отлично (5)");
// // // // // // // // // }
// // // // // // // // // else if (score >= 71) {
// // // // // // // // //     Console.WriteLine("Оценка: Хорошо (4)");
// // // // // // // // // }
// // // // // // // // // else if (score >= 51) {
// // // // // // // // //     Console.WriteLine("Оценка: Удовлетворительно (3)");
// // // // // // // // // }
// // // // // // // // // else {
// // // // // // // // //     Console.WriteLine("Оценка: Неудовлетворительно (2)");
// // // // // // // // // }

// // // // // // // // // Console.Write("Введите количество посещений (из 19): ");
// // // // // // // // // int attendance = int.Parse(Console.ReadLine());
// // // // // // // // // Console.Write("Введите средний балл по практике: ");
// // // // // // // // // double practiceGpa = double.Parse(Console.ReadLine());
// // // // // // // // // bool goodAttendance = attendance >= 14; 
// // // // // // // // // bool goodGrades = practiceGpa >= 3.0; 
// // // // // // // // // if (goodAttendance && goodGrades) {
// // // // // // // // //     Console.WriteLine("+ Допуск к экзамену разрешён.");
// // // // // // // // // }
// // // // // // // // // else if (!goodAttendance && goodGrades) {
// // // // // // // // //     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// // // // // // // // // }
// // // // // // // // // else if (goodAttendance && !goodGrades) {
// // // // // // // // //     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// // // // // // // // // }
// // // // // // // // // else {
// // // // // // // // //     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// // // // // // // // // }

// // // // // // // // Console.Write("Введите ваш возраст: ");
// // // // // // // // int age = int.Parse(Console.ReadLine());
// // // // // // // // string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// // // // // // // // Console.WriteLine($"Вы {ageGroup}.");

// // // // // // // // Console.Write("\nВведите температуру за окном (°C): ");
// // // // // // // // double temp = double.Parse(Console.ReadLine());
// // // // // // // // string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// // // // // // // // Console.WriteLine($"За окном {weather}.");

// // // // // // // // Console.Write("\nВведите число: ");
// // // // // // // // int n = int.Parse(Console.ReadLine());
// // // // // // // // string parity = n % 2 == 0 ? "чётное" : "нечётное";
// // // // // // // // Console.WriteLine($"Число {n} - {parity}.");

// // // // // // // Console.WriteLine("Меню");
// // // // // // // Console.WriteLine("1. Посмотреть расписание");
// // // // // // // Console.WriteLine("2. Посмотреть оценки");
// // // // // // // Console.WriteLine("3. Связаться с преподавателем");
// // // // // // // Console.WriteLine("4. Выйти");
// // // // // // // Console.Write("Выберите пункт (1-4): ");
// // // // // // // string choice = Console.ReadLine();
// // // // // // // switch (choice) {
// // // // // // //     case "1":
// // // // // // //         Console.WriteLine("Расписание: ИСП-244, каб. 102, 08:30");
// // // // // // //         break;
// // // // // // //     case "2":
// // // // // // //         Console.WriteLine("Ваши оценки: ИРСПО - 20, РМП - 35,");
// // // // // // //         break;
// // // // // // //     case "3":
// // // // // // //         Console.WriteLine("Email: denis.leontev92@yandex.ru");
// // // // // // //         break;
// // // // // // //     case "4":
// // // // // // //         Console.WriteLine("До свидания!");
// // // // // // //         break;
// // // // // // //     default:
// // // // // // //         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
// // // // // // //         break;
// // // // // // // }

// // // // // // // Console.Write("\nВведите номер дня недели (1-7): ");
// // // // // // // int dayNumber = int.Parse(Console.ReadLine());
// // // // // // // switch (dayNumber) {
// // // // // // //     case 1:
// // // // // // //     case 2:
// // // // // // //     case 3:
// // // // // // //     case 4:
// // // // // // //     case 5:
// // // // // // //         Console.WriteLine("Рабочий день - пора учиться!");
// // // // // // //         break;
// // // // // // //     case 6:
// // // // // // //     case 7:
// // // // // // //         Console.WriteLine("Выходной - заслуженный отдых.");
// // // // // // //         break;
// // // // // // //     default:
// // // // // // //         Console.WriteLine("Такого дня не существует.");
// // // // // // //         break;
// // // // // // // }

// // // // // // // Console.Write("\nВведите номер месяца (1-12): ");
// // // // // // // int month = int.Parse(Console.ReadLine());
// // // // // // // switch (month) {
// // // // // // //     case 12:
// // // // // // //     case 1:
// // // // // // //     case 2:
// // // // // // //         Console.WriteLine("Зима");
// // // // // // //         break;
// // // // // // //     case 3:
// // // // // // //     case 4:
// // // // // // //     case 5:
// // // // // // //         Console.WriteLine("Весна");
// // // // // // //         break;
// // // // // // //     case 6:
// // // // // // //     case 7:
// // // // // // //     case 8:
// // // // // // //         Console.WriteLine("Лето");
// // // // // // //         break;
// // // // // // //     case 9:
// // // // // // //     case 10:
// // // // // // //     case 11:
// // // // // // //         Console.WriteLine("Осень");
// // // // // // //         break;
// // // // // // //     default:
// // // // // // //         Console.WriteLine("Нет такого месяца");
// // // // // // //         break;
// // // // // // // }

// // // // // // Random random = new Random();
// // // // // // int secret = random.Next(1, 101);

// // // // // // int attempts = 0;
// // // // // // bool guessed = false;

// // // // // // Console.WriteLine("Угадай число (1-100)");
// // // // // // Console.WriteLine("Я загадал число. Попробуй угадать!");

// // // // // // while (!guessed) {
// // // // // //     Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
// // // // // //     string input = Console.ReadLine();

// // // // // //     if (!int.TryParse(input, out int guess)) {
// // // // // //         Console.WriteLine("!!! Введи целое число, а не текст!");
// // // // // //         continue;
// // // // // //     }

// // // // // //     if (guess < 1 || guess > 100) {
// // // // // //         Console.WriteLine("!!! Число должно быть от 1 до 100!");
// // // // // //         continue;
// // // // // //     }

// // // // // //     attempts++;

// // // // // //     if (guess < secret) {
// // // // // //         int diff = secret - guess;
// // // // // //         string hint = GetHint(diff);
// // // // // //         Console.WriteLine($"↑ Больше! {hint}\n");
// // // // // //     }
// // // // // //     else if (guess > secret) {
// // // // // //         int diff = guess - secret;
// // // // // //         string hint = GetHint(diff);
// // // // // //         Console.WriteLine($"↓ Меньше! {hint}\n");
// // // // // //     }
// // // // // //     else {
// // // // // //         guessed = true;
// // // // // //     }
// // // // // // }

// // // // // // string result = attempts <= 7
// // // // // //     ? $"Отличный результат! Всего {attempts} попыток."
// // // // // //     : $"Число найдено за {attempts} попыток. Можно лучше!";

// // // // // // Console.WriteLine($"🎉 Правильно! Загаданное число: {secret}");
// // // // // // Console.WriteLine($"{result}");

// // // // // // string GetHint(int difference) {
// // // // // //     switch (difference) {
// // // // // //         case <= 3:
// // // // // //             return "🔥 Горячо!";
// // // // // //         case <= 10:
// // // // // //             return "🌡 Тепло.";
// // // // // //         case <= 25:
// // // // // //             return "🌀 Прохладно.";
// // // // // //         default:
// // // // // //             return "❄ Холодно!";
// // // // // //     }
// // // // // // }

// // // // // Задание 1. Проверка пароля
// // // // // string p1 = Console.ReadLine();
// // // // // string p2 = Console.ReadLine();

// // // // // if (p1 == p2) {
// // // // //     Console.WriteLine("Пароль принят");
// // // // // }
// // // // // else {
// // // // //     Console.WriteLine("Пароль не принят");
// // // // // }

// // // // // Задание 2. Роскомнадзор
// // // // int age = int.Parse(Console.ReadLine());

// // // // if (age >= 18) {
// // // //     Console.WriteLine("Доступ разрешён");
// // // // }
// // // // else {
// // // //     Console.WriteLine("Доступ запрещён");
// // // // }

// // // // Задание 3. Простой калькулятор (switch/case)
// // // Console.Write("Первое число: ");
// // // int a = int.Parse(Console.ReadLine());
// // // Console.Write("Второе число: ");
// // // int b = int.Parse(Console.ReadLine());
// // // Console.Write("Операция (+, -, *, /): ");
// // // string op = Console.ReadLine();

// // // switch (op) {
// // //     case "+":
// // //         Console.WriteLine($"{a} + {b} = {a + b}");
// // //         break;
// // //     case "-":
// // //         Console.WriteLine($"{a} - {b} = {a - b}");
// // //         break;
// // //     case "*":
// // //         Console.WriteLine($"{a} * {b} = {a * b}");
// // //         break;
// // //     case "/":
// // //         if (b == 0) {
// // //             Console.WriteLine("На ноль делить нельзя");
// // //         }
// // //         else {
// // //             Console.WriteLine($"{a} / {b} = {a / b}");
// // //         }
// // //         break;
// // //     default:
// // //         Console.WriteLine("Неизвестная операция");
// // //         break;
// // // }

// // // Задание 4. Только положительные
// // int x1 = int.Parse(Console.ReadLine());
// // int x2 = int.Parse(Console.ReadLine());
// // int x3 = int.Parse(Console.ReadLine());
// // int sum = 0;

// // if (x1 > 0) {
// //     sum = sum + x1;
// // }
// // if (x2 > 0) {
// //     sum = sum + x2;
// // }
// // if (x3 > 0) {
// //     sum = sum + x3;
// // }

// // Console.WriteLine(sum);

// // Задание 5. Путешествие в Тёмный Лабиринт
// Console.WriteLine("Вы стоите перед первой дверью. Выберите путь (A или B):");
// string path = Console.ReadLine();

// if (path == "A") {
//     Console.WriteLine("Вы вошли к дракону!");
//     Console.WriteLine("Загадка: Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.");
//     string ans = Console.ReadLine();
//     if (ans == "рыба") {
//         Console.WriteLine("Правильно! Дракон открыл дверь в следующую комнату.");
//     }
//     else {
//         Console.WriteLine("Неверно! Дракон вас съел!");
//     }
// }
// else if (path == "B") {
//     Console.WriteLine("Вы в тёмной комнате. Выберите дверь (1 или 2):");
//     string door = Console.ReadLine();
//     if (door == "1") {
//         Console.WriteLine("Победа! Вы нашли сокровища Dungeon Master'а!");
//     }
//     else {
//         Console.WriteLine("Вы попали в ловушку с ядовитыми шипами!");
//     }
// }
// else {
//     Console.WriteLine("Вы заблудились в темноте.");
// }

