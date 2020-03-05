using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Datos
{
    interface DataProvider
    {
        IDbConnection connection(String stringConnection);
        IDbDataAdapter adapter(String commad, IDbConnection connection);
        IDbCommand command(String command);
        IDataParameter parameter(Parameter parameter);
    }
}
