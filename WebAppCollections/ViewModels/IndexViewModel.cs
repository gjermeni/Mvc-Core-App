using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppCollections.Models;

namespace WebAppCollections.ViewModels
{
    public class IndexViewModel
    { 
        public IEnumerable<Books> Book { get; set; }
        public string CurrentMessage { get; set; }
    }
}
