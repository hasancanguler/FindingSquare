using FindingSquare.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindingSquare.Repository
{
    public class NotePad : IDataProvider
    {
        public List<Axis> Get()
        {
            List<Axis> axisList = new List<Axis>();
            //Read Txt
            string[] lines = System.IO.File.ReadAllLines(@"Data.txt");

            foreach (string line in lines)
            {
                string[] coor = line.Split(",");
                axisList.Add(new Axis
                {
                    X = Convert.ToInt32(coor[0]),
                    Y = Convert.ToInt32(coor[1])
                });
            }

            return axisList;
        }
    }
}
