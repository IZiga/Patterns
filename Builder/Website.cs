using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Website
    {
        public string name { private get; set; }
        public Cms cms { private get; set; }
        public int price { private get; set; }

        public override string ToString()
        {
            return $"Website: ({nameof(name)}='{name}', {nameof(cms)}='{cms}', {nameof(price)}={price})";
        }
    }
}
