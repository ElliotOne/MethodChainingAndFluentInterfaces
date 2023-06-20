namespace MethodChainingAndFluentInterfaces
{
    public class Calculator
    {
        private int _result;

        public Calculator Add(int number)
        {
            _result += number;
            return this;
        }

        public Calculator Subtract(int number)
        {
            _result -= number;
            return this;
        }

        public int GetResult()
        {
            return _result;
        }
    }
}
