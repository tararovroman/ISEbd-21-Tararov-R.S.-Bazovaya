using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPlanes
{
    public class PlaneComparer : IComparer<Vehicle>
    {
        /// <summary>
        /// Метод сравнения для объектов
        /// </summary>
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().FullName.CompareTo(y.GetType().FullName);
            }
            if (x.GetType() == y.GetType() && x is Istrebitel)
            {
                return ComparerIstrebitel((Istrebitel)x, (Istrebitel)y);
            }
            if (x.GetType() == y.GetType() && x is WarPlane)
            {
                return ComparerWarPlane((WarPlane)x, (WarPlane)y);
            }
            return 0;
        }

        private int ComparerWarPlane(WarPlane x, WarPlane y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerIstrebitel(Istrebitel x, Istrebitel y)
        {
            var res = ComparerWarPlane(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Rockets != y.Rockets)
            {
                return x.Rockets.CompareTo(y.Rockets);
            }
            if (x.Machinegun != y.Machinegun)
            {
                return x.Machinegun.CompareTo(y.Machinegun);
            }
            if (x.Turbine != y.Turbine)
            {
                return x.Turbine.CompareTo(y.Turbine);
            }
            if (x.Lines != y.Lines)
            {
                return x.Lines.CompareTo(y.Lines);
            }
            return 0;
        }
    }
}
