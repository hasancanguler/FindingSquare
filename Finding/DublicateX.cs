using FindingSquare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingSquare.Finding
{
    public class DublicateX : IFindDublicate
    {
        public List<Axis> Find(List<Axis> axisList)
        {
            List<Axis> axisListResult = new List<Axis>();
            var dubList = axisList.GroupBy(g => g.X).ToList();

            foreach (var item in dubList)
            {
                var itemResult = axisList.Where(f => f.X.Equals(item.Key)).ToList();

                if (itemResult.Count >= 2)
                {
                    axisListResult.AddRange(itemResult);
                }
            }
            return axisListResult;
        }
    }
}
