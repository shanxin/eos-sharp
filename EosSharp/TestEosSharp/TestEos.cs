using EosSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEosSharp
{
    public class TestEos
    {
        public string Result;

        public async Task CheckAsync()
        {
            Eos eos = new Eos(new EosConfigurator()
            {
                HttpEndpoint = "https://nodes.eos42.io", //Mainnet
                ChainId = "aca376f206b8fc25a6ed44dbdc66547c36c6c33e3a119ffbeaef943642f0e906",
                ExpireSeconds = 60,
                SignProvider = new DefaultSignProvider("myprivatekey")
            });

            var result = await eos.GetInfo();
            Result = result.ToString();
        }
    }
}
