namespace ConsoleCaculate
{
    internal class Calculator
    {
        public double GetSumm(double valueOne, double valueTwo)
        {
            return valueOne + valueTwo;
        }

        public double GetMultiply(double valueOne, double valueTwo)
        {
            return valueOne * valueTwo;
        }

        public double GetDifference(double valueOne, double valueTwo)
        {
            return valueOne - valueTwo;
        }

        public double GetDivide(double valueOne, double valueTwo)
        {
            if (valueTwo == 0.0000000000)
            {
                throw new DivideByZeroException("Деление на 0 не возможно!");
            }

            return valueOne / valueTwo;
        }

        public double GetDegree(double value, double degree)
        {
            return Math.Pow(value, degree);
        }

        public double GetRoot(double value, double root)
        {
            //проверить корень
            if (root == 0.0000000000)
            {
                throw new Exception("Не возмжно найти 0-вой корень!");
            }

            if (value < 0)
            {
                throw new Exception("Не возмжно найти корень отрицательного числа!");
            }

            return Math.Exp(1 / root * Math.Log(value));
        }

        public double GetProcent(double valueOne, double valueTwo)
        {
            if (valueOne < 0 && valueTwo >= 0 || valueTwo < 0 && valueOne >= 0)
            {
                throw new Exception("Проценты от значений с разными знакоми определить невозможно!");
            }

            return (valueOne * valueTwo) / 100;
        }

        public double GetLog(double value, double? footing)
        {
            if (footing == null || footing == 0)
            {
                return Math.Log(value);
            }

            if (footing < 0)
            {
                throw new Exception("Логарифм не может иметь отрицательно основание!");
            }

            if (footing == 1)
            {
                throw new Exception("Основание не должно быть равно единице!");
            }

            if (value <= 0)
            {
                throw new Exception("Итоговое число логарифма должно быть больше нуля!");
            }

            return Math.Log(value, footing.Value);
        }

        public double GetSin(double value)
        {
            return Math.Sin(value);
        }

        public double GetCtan(double value)
        {
            double sin = Math.Sin(value);

            if (sin == 0.0000000000000)
            {
                throw new Exception("Значение для определения катангенса не может быть равно 0");
            }

            double ctan = Math.Cos(value) / Math.Sin(value);

            return ctan;
        }
    }
}
