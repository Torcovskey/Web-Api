using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Converter
{
    public interface IConverter<Tin, Tout>
    {
        public IEnumerable<Tout> Convert(IEnumerable<Tin> entities);
        public Tout ConvertOne(Tin entity);
    }
}
