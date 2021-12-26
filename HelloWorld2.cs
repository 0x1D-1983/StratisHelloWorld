using System;
using Stratis.SmartContracts;


[Deploy]
public class HelloWorld2 : SmartContract
{
    private int Index
    {
        get
        {
            return State.GetInt32("Index");
        }
        set
        {
            State.SetInt32("Index", value);
        }
    }

    private int Bounds
    {
        get
        {
            return State.GetInt32("Bounds");
        }
        set
        {
            State.SetInt32("Bounds", value);
        }
    }

    private string Greeting
    {
        get
        {
            Index++;
            if (Index >= Bounds)
            {
                Index = 0;
            }

            return State.GetString("Greeting" + Index);
        }
        set
        {
            State.SetString("Greeting" + Bounds, value);
            Bounds++;
        }
    }

    public HelloWorld2(ISmartContractState smartContractState) : base(smartContractState)
    {
        this.Bounds = 0;
        this.Index = -1;
        this.Greeting = "Hello World!";
    }

    public string SayHello()
    {
        return this.Greeting;
    }

    public string AddGreeting(string helloMessage)
    {
        this.Greeting = helloMessage;
        return "Added '" + helloMessage + "' as a greeting.";
    }
}


