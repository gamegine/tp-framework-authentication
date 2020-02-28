﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace framework_authentication.Models
{
    public class Token
    {
        private string token;
        private DateTime expireDate;
        private bool valid;

        public Token()
        {
            this.valid = true;
            this.token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        }

        public Token(DateTime expireDate)
        {
            this.valid = true;
            this.token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            this.expireDate = expireDate;
        }

        public bool isValid()
        {
            if (this.expireDate > DateTime.Now && valid)
            {
                return true;
            }
            return false;
            
        }

        public bool delete()
        {
            this.valid = false;
            return true;
        }

        public string getToken()
        {
            return this.token;
        }

        public DateTime getExpirationDate()
        {
            return this.expireDate;
        }

    }
}
