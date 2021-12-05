using System;
using Stratis.SmartContracts;


    [Deploy]
    public class HelloWorld : SmartContract
    {
        private string Greeting
        {
            get
            {
                return State.GetString("Greeting");
            }
            set
            {
                State.SetString("Greeting", value);
            }
        }

        public HelloWorld(ISmartContractState contractState) : base(contractState)
        {
            Greeting = "Hello World!";
        }

        public string SayHello()
        {
            return Greeting;
        }
    }


