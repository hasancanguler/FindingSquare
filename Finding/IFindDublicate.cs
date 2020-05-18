using FindingSquare.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FindingSquare.Finding
{
    public interface IFindDublicate
    {
        List<Axis> Find(List<Axis> axisList);
    }
}
