using FindingSquare.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingSquare.Finding
{
    public class DublicateY : IFindDublicate
    {
        public List<Axis> Find(List<Axis> axisList)
        {
            List<Axis> axisListResult = new List<Axis>();
            var dubList = axisList.GroupBy(g => g.Y).ToList();

            foreach (var item in dubList)
            {
                var itemResult = axisList.Where(f => f.Y.Equals(item.Key)).ToList();
                if (itemResult.Count >= 2)
                {
                    axisListResult.AddRange(itemResult);
                }
            }
            return axisListResult;
        }
    }
}
