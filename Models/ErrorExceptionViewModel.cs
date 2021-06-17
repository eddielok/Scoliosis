using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scoliosis.Models
{
    public class ErrorExceptionViewModel
    {
        public int Id { get; set; }

        public string GUIDNumber { get; set; }

        public DateTime ExceptionDateTime { get; set; }

        public string ExceptionDetail { get; set; }

        public string ExceptionInnerDetail { get; set; }

    }
}
