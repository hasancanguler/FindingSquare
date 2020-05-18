using FindingSquare.Finding;
using FindingSquare.Model;
using FindingSquare.Repository;
using FindingSquare.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindingSquare.Controller
{
    public class FindingSquare
    {
        AxisBuss axisBuss = new AxisBuss();
        IDataProvider dataProvider = new NotePad();
        IFindDublicate findDublicate;
        public List<Square> Find()
        {
            int squareCount = 0;
            List<Square> squares = new List<Square>();
            List<Axis> axisList = dataProvider.Get();

            findDublicate = new DublicateX();
            List<Axis> DublicateX = findDublicate.Find(axisList);

            findDublicate = new DublicateY();
            List<Axis> DublicateY = findDublicate.Find(axisList);

            var XGroupList = DublicateX.GroupBy(g => g.X).Distinct().ToList();
            foreach (var itemY in XGroupList)
            {
                List<Axis> square = new List<Axis>();

                foreach (var item in itemY)
                {
                    square.AddRange(DublicateY.Where(f => f.Y.Equals(item.Y)).ToList());
                }

                if (square.Count >= 4)
                {
                    int count = square.Where(f => f.X != itemY.Key).GroupBy(g => g.Y).Count();
                    if (count >= 2)
                    {
                        squareCount++;
                        squares.Add(new Square()
                        {
                            Id = squareCount,
                            Axis = square
                        });
                    }
                }
            }
            return squares;
        }
    }
}
