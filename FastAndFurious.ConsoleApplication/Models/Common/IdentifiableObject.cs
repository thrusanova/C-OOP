using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastAndFurious.ConsoleApplication.Models.Common
{

    public class IdentifiableObject : IIdentifiable
    {
        private readonly int id;

        public IdentifiableObject()
        {
            this.id = DataGenerator.GenerateId();
        }

        public int Id
        {
            get
            {
                return this.id;
            }

        }
    }
    }

