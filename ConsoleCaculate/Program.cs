namespace ConsoleCaculate
{
    internal class Program
    {
        private static double ValueOne { get; set; }

        private static double? ValueTwo { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор\n");

            Calculator calc = new Calculator();

            double? result = null;

            while (true)
            {
                try
                {
                    Console.Write("Выберите операцию:\n1. Сложение\n2. Вычитание\n3. Умножение\n4. Деление\n5. Возведеие в степень\n6. Нахождение корня\n7. Процент от числа\n8. Логарифм числа\n9. Синус числа\n10. Катангенс числа\n0. Выход из программы\n\nВаш выбор: ");

                    int operation = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    switch (operation)
                    {
                        case 0:
                            Console.WriteLine("До свидания!");
                            return;
                        case 1:
                            Console.WriteLine("Сложение");
                            GetData(2);
                            result = calc.GetSumm(ValueOne, ValueTwo!.Value);
                            break;
                        case 2:
                            Console.WriteLine("Вычитание");

                            Console.WriteLine("Примечание: перыое число - уменьшаемое; второе число - вычитаемое\n");

                            GetData(2);
                            result = calc.GetDifference(ValueOne, ValueTwo!.Value);
                            break;
                        case 3:
                            Console.WriteLine("Умножение");
                            GetData(2);
                            result = calc.GetMultiply(ValueOne, ValueTwo!.Value);
                            break;
                        case 4:
                            Console.WriteLine("Деление");

                            Console.WriteLine("Примечание: перыое число - делимое; второе число - делитель\n");

                            GetData(2);
                            try
                            {
                                result = calc.GetDivide(ValueOne, ValueTwo!.Value);
                            }
                            catch (Exception ex)
                            {
                                PrintError(ex.Message);
                                result = null;
                            }
                            break;
                        case 5:
                            Console.WriteLine("Возведеие в степень");

                            Console.WriteLine("Примечание: перыое число - число, которое возводится в степень; второе число - степень\n");

                            GetData(2);

                            try
                            {
                                result = calc.GetDegree(ValueOne, ValueTwo!.Value);
                            }
                            catch (Exception ex)
                            {
                                PrintError(ex.Message);
                                result = null;
                            }
                            break;
                        case 6:
                            Console.WriteLine("Нахождение корня");

                            Console.WriteLine("Примечание: перыое число - число, корень которого находится; второе число - вариация корня\n");

                            GetData(2);
                            try
                            {
                                result = calc.GetRoot(ValueOne, ValueTwo!.Value);
                            }
                            catch (Exception ex)
                            {
                                PrintError(ex.Message);
                                result = null;
                            }
                            break;
                        case 7:
                            Console.WriteLine("Процент от числа");

                            Console.WriteLine("Примечание: в данном методе находится процентное отношение первого числа ко второму\n");

                            GetData(2);

                            try
                            {
                                result = calc.GetProcent(ValueOne, ValueTwo!.Value);
                            }
                            catch (Exception ex)
                            {
                                PrintError(ex.Message);
                                result = null;
                            }
                            break;
                        case 8:
                            Console.WriteLine("Логарифм числа");

                            Console.WriteLine("Примечание: для нахождения натурального логарифма второе число (основание) можно не вводить\n");

                            GetData(2);

                            try
                            {
                                result = calc.GetLog(ValueOne, ValueTwo);
                            }
                            catch (Exception ex)
                            {
                                PrintError(ex.Message);
                                result = null;
                            }
                            break;
                        case 9:
                            Console.WriteLine("Синус числа");
                            GetData(1);

                            try
                            {
                                result = calc.GetSin(ValueOne);
                            }
                            catch (Exception ex)
                            {
                                PrintError(ex.Message);
                                result = null;
                            }

                            break;
                        case 10:
                            Console.WriteLine("Катангенс числа");
                            GetData(1);

                            try
                            {
                                result = calc.GetCtan(ValueOne);
                            }
                            catch (Exception ex)
                            {
                                PrintError(ex.Message);
                                result = null;
                            }

                            break;
                        default:
                            throw new Exception("выбранного варината не предусмотрено!");
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Не корректные данные!");
                    Console.WriteLine("Повторите ввод!\n");
                }

                if (result != null) Console.WriteLine($"Результат вычислений: {result}\n");

                result = null;
            }

        }

        private static void GetData(int countValues)
        {
            try
            {
                if (countValues == 1)
                {
                    Console.Write("Введите число для операции: ");
                    ValueOne = Convert.ToDouble(Console.ReadLine());
                }
                else if (countValues == 2)
                {

                    Console.Write("Введите первое число для операции: ");
                    ValueOne = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число для операции: ");
                    ValueTwo = Convert.ToDouble(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Введённые данные не корректны!");
                Console.WriteLine("Повторите ввод...\n\n");

                GetData(countValues);
            }
        }

        private static void PrintError(string errorMessage)
        {
            Console.WriteLine($"Error: {errorMessage}\n");
        }
    }
}
