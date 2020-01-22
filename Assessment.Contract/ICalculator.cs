using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Contract
{
    public interface ICalculator: IDisposable
    {
        double Add(double a, double b);
        double Sub(double a, double b);

        double divide(double a, double b);
    }
}
