namespace ConsoleCaculate
{
    public class Calculator
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

            if ((degree % 1 >= 0.00000000000000000001 || degree % 1 <= 0.9999999999999999999) && (value < 0 || value == 1))
            {
                throw new Exception("Не возмжно определить показательную степень числа, которое меньше 0 или равно еденице!");
            }

            return Math.Pow(value, degree);
        }

        public double GetRoot(double value, double root)
        {
            //проверить корень
            if (root == 0.0000000000)
            {
                throw new Exception("Не возмжно найти 0-вой корень!");
            }

            if (value < 0 && root % 2 == 1)
            {
                throw new Exception("Не возмжно найти корень отрицательного числа!");
            }

            return Math.Exp(1 / root * Math.Log(value));
        }

        public double GetProcent(double value, double procent)
        {
            switch (procent)
            {
                case > 0:
                    return (value * procent) / 100;
                case < 0:
                    return (value * procent * -1) / 100 + value;
                default:
                    return 0;
            }
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

            double cos = Math.Cos(value);

            double ctan = cos / sin;

            return ctan;
        }
    }
}
