using FindingSquare.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindingSquare.Repository
{
    public interface IDataProvider
    {
        public List<Axis> Get();
    }
}
