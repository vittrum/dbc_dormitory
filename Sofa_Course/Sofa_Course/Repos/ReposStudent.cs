﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sofa_Course.Repos
{
    class ReposStudent
    {
        private Connection sqlConnection;
        public ReposStudent(Connection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }
    }
}
