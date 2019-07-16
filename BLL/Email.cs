using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Email
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string ValidationCode { get; set; }

        void MakeValidationCode()
        {
            ValidationCode = new Random().Next().ToString();
        }
        public void Send(string host)
        {
            string validationUrl = $"{host}/Email/Validate?code={ValidationCode}&id={Id}";
        }
    }
}
