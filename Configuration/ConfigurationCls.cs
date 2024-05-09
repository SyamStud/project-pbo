using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace project_pbo.Configuration
{
    internal abstract class ConfigurationCls
    {
        // METHOD INSERT, UPDATE, DELETE
        public abstract int NonQuery(string query);

        // METHOD SELECT
        public abstract DataTable Query(string query);
    }
}