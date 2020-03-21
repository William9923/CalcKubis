using System;
using Xunit;

namespace Calc_Kubis
{
    public class ExpressionTest
    {

        [Theory]
        [InlineData(2018, 2018)]
        [InlineData(135.18, 135.18)]
        public void TerminalExprTest(double expected, double action)
        {
            Expression expr = new TerminalExpression(action);
            Assert.Equal(expected, expr.Solve(), 5);
        }

        [Theory]
        [InlineData(-2018, 2018)]
        [InlineData(-135.18, 135.18)]
        public void NegativeExprTest(double expected, double action)
        {
            Expression expr = new TerminalExpression(action);
            NegativeExpression negExpr = new NegativeExpression(expr);
            Assert.Equal(expected, negExpr.Solve(), 5);
        }

        [Theory]
        [InlineData(2018, 2017, 4035)]
        [InlineData(135.18, 135.18, 270.360)]
        public void AddExprTest(double firstInput, double secondInput, double expected)
        {
            Expression expr1 = new TerminalExpression(firstInput);
            Expression expr2 = new TerminalExpression(secondInput);
            Expression exprResult = new AddExpression(expr1, expr2);
            Assert.Equal(expected, exprResult.Solve(), 5);
        }

        [Theory]
        [InlineData(2018, 2017, 1)]
        [InlineData(135.18, 135, 0.18)]
        public void SubstractExprTest(double firstInput, double secondInput, double expected)
        {
            Expression expr1 = new TerminalExpression(firstInput);
            Expression expr2 = new TerminalExpression(secondInput);

            NegativeExpression negExpr = new NegativeExpression(expr2);

            Expression exprResult = new AddExpression(expr1, negExpr);
            Assert.Equal(expected, exprResult.Solve(), 5);
        }

        [Theory]
        [InlineData(135, 18, 2430)]
        [InlineData(-1, 11, -11)]
        [InlineData(1, -11, -11)]
        [InlineData(-0.1, -11, 1.1)]
        public void MultExprTest(double firstInput, double secondInput, double expected)
        {
            Expression expr1;
            Expression expr2;
            if (firstInput < 0) {
                Expression expr = new TerminalExpression(Math.Abs(firstInput));
                expr1 = new NegativeExpression(expr);
            } else {
                expr1 = new TerminalExpression(firstInput);
            }

            if (secondInput < 0) {
                Expression expr = new TerminalExpression(Math.Abs(secondInput));
                expr2 = new NegativeExpression(expr);
            } else {
                expr2 = new TerminalExpression(secondInput);
            }

            Expression exprResult = new MultExpression(expr1, expr2);

            Assert.Equal(expected, exprResult.Solve(), 5);
        }

        [Theory]
        [InlineData(135, 5, 27)]
        [InlineData(-11, -11, 1)]
        [InlineData(-11, 1, -11)]
        [InlineData(5.1, 2, 2.55)]
        public void DivExprTest(double firstInput, double secondInput, double expected)
        {
            Expression expr1;
            Expression expr2;

            if (firstInput < 0) {
                Expression expr = new TerminalExpression(Math.Abs(firstInput));
                expr1 = new NegativeExpression(expr);
            } else {
                expr1 = new TerminalExpression(firstInput);
            }

            if (secondInput < 0) {
                Expression expr = new TerminalExpression(Math.Abs(secondInput));
                expr2 = new NegativeExpression(expr);
            } else {
                expr2 = new TerminalExpression(secondInput);
            }

            Expression exprResult = new DivExpression(expr1, expr2);

            Assert.Equal(expected, exprResult.Solve(), 5);
        }

        [Theory]
        [InlineData(2, 5, 32)]
        [InlineData(-1, 10, 1)]
        [InlineData(2.5, 2, 6.25)]
        [InlineData(5.1, 2, 26.01)]
        public void PowerExprTest(double firstInput, double secondInput, double expected)
        {
            Expression expr1;
            Expression expr2;

            if (firstInput < 0)
            {
                Expression expr = new TerminalExpression(Math.Abs(firstInput));
                expr1 = new NegativeExpression(expr);
            }
            else
            {
                expr1 = new TerminalExpression(firstInput);
            }

            if (secondInput < 0)
            {
                Expression expr = new TerminalExpression(Math.Abs(secondInput));
                expr2 = new NegativeExpression(expr);
            }
            else
            {
                expr2 = new TerminalExpression(secondInput);
            }

            Expression exprResult = new PowerExpression(expr1, expr2);

            Assert.Equal(expected, exprResult.Solve(), 5);
        }

        [Theory]
        [InlineData(26.01, 5.1)]
        [InlineData(144, 12)]
        [InlineData(676.5201, 26.01)]
        [InlineData(1, 1)]
        public void RootExprTest(double firstInput, double expected)
        {
            Expression expr = new TerminalExpression(firstInput);

            Expression exprResult = new RootExpression(expr);

            Assert.Equal(expected, exprResult.Solve(), 5);
        }
    }

    public class ParserTest
    {
        [Theory]
        [InlineData("5x3", "5 x 3")]
        [InlineData("5--5", "5 - ; 5")]
        [InlineData("-5÷-3", "; 5 ÷ ; 3")]
        [InlineData("√5--10", "√ 5 - ; 10")]
        [InlineData("2,58+3x4--5", "2,58 + 3 x 4 - ; 5")]
        [InlineData("22-99-9", "22 - 99 - 9")]
        [InlineData("2+4x10-4", "2 + 4 x 10 - 4")]
        [InlineData("2,45+6+8-((9+9)^0,5)", "2,45 + 6 + 8 - ( ( 9 + 9 ) ^ 0,5 )")]
        [InlineData("2+9x5÷10-√10", "2 + 9 x 5 ÷ 10 - √ 10")]
        [InlineData("2^(5+10)", "2 ^ ( 5 + 10 )")]
        [InlineData("3x-5", "3 x ; 5")]
        public void parsingTest(string actual, string expected)
        {
            Parser P = new Parser(actual);

            Assert.Equal(expected, P.GetExpr());
        }
    }

    public class EvaluatorTest
    {
        [Theory]
        [InlineData("10+5", 15)]
        [InlineData("10x5", 50)]
        [InlineData("10-5", 5)]
        [InlineData("10÷5", 2)]
        [InlineData("10^5", 100000)]
        [InlineData("5--5", 10)]
        [InlineData("-5÷-3", 1.6666667)]
        [InlineData("√5--10", 12.236067977)]
        [InlineData("2,58+3x4--5", 19.58)]
        [InlineData("22-99-9", -86)]
        [InlineData("2+4x10-4", 38)]
        [InlineData("2,45+6+8-((9+9)^0,5)", 12.207359312)]
        [InlineData("2+9x5÷10-√10", 3.33772233983)]
        [InlineData("2^(5+1)", 64)]
        [InlineData("3x-5", -15)]
        public void evaluatorTest(string actual, double expected)
        {
            Evaluator Ev = new Evaluator(actual);

            Assert.Equal(expected, Ev.Evaluate().Solve(), 5);
        }
    }

    public class exceptionTest
    {
        [Fact]
        public void DivideByZeropExceptionTest()
        {
            Evaluator action = new Evaluator("5÷0");

            var ex = Assert.Throws<DivideByZeroException>(() => action.Evaluate().Solve());

            Assert.Equal($"{ex.getDivident()} is divided by zero\n", ex.errorMessage());
        }


        [Fact]
        public void ImaginaryExceptionTest()
        {
            Evaluator action = new Evaluator("√(-100)");

            var ex = Assert.Throws<ImaginaryException>(() => action.Evaluate().Solve());

            Assert.Equal("Imaginary Expression\n", ex.errorMessage());
        }

        [Theory]
        [InlineData("√x4+3")]
        [InlineData("4++2")]
        [InlineData("4x+2")]
        [InlineData("(42)(34)")]
        [InlineData("√+22")]
        [InlineData("56++")]
        public void UndefinedTokenExceptionTest(string operation)
        {
            Evaluator action = new Evaluator(operation);

            var ex = Assert.Throws<UndefinedToken>(() => action.Evaluate().Solve());

            Assert.Equal($"{ex.getToken()} is undefined.", ex.errorMessage());
        }

        [Theory]
        [InlineData("(500))")]
        [InlineData("(73+31)+3)")]
        public void ParenthesesErrorExceptionTest(string operation)
        {
            Evaluator action = new Evaluator(operation);

            var ex = Assert.Throws<ParenthesesErrorException>(() => action.Evaluate().Solve());

            Assert.Equal("Parentheses Error\n", ex.errorMessage());
        }

        [Theory]
        [InlineData("((500)")]
        [InlineData("(((73+31)+3)")]
        public void SyntaxErrorExceptionTest(string operation)
        {
            Evaluator action = new Evaluator(operation);

            var ex = Assert.Throws<SyntaxErrorException>(() => action.Evaluate().Solve());

            Assert.Equal("Syntax Error\n", ex.errorMessage());
        }
    }

    public class dataCollectorTest
    {
        [Theory]
        [InlineData("5+3+4", "+", "5+3+4+")]
        [InlineData("5", "-", "5-")]
        public void addTest(string expr, string add, string expected)
        {
            DataCollector DC = new DataCollector();

            DC.SetExpr(expr);

            DC.ChangeState();

            DC.AddStringExpression(add);

            Assert.Equal(expected, DC.GetExpr());
        }

        [Theory]
        [InlineData("5+3+4", "5+3+")]
        [InlineData("5-", "5")]
        public void backSpaceTest(string expr, string expected)
        {
            DataCollector DC = new DataCollector();

            DC.SetExpr(expr);

            DC.BackSpaceExpression();

            Assert.Equal(expected, DC.GetExpr());
        }
    }
}

