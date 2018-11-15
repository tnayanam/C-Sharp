using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests
{
    class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return ""; // see here we have created  fale file class which does not  actually reference to any files in particular also we have kept this class in testing project 
            // so it is not available to the production code. 
         }
    }
}

// read this after understanding all code: so so far we have got everything we wanted but still the VideoService class is tightly ocupled with FileReader class, we need
// to use an IFilerader interface there
// so we have three options for that
// 1. Pass IfileReader as a parameter to ReadVideoTitle Method
// 2. Pass using a property
// 3. Pass using a constructor