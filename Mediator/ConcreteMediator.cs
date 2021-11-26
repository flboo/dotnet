namespace Dotnet.Mediator
{
    public class ConcreteMediator : Mediator
    {
        private ConcretteColleague1 concretteColleague1;
        private ConcretteColleague2 concretteColleague2;

        public ConcretteColleague1 Colleague1
        {
            set { this.concretteColleague1 = value; }
        }

        public ConcretteColleague2 Colleague2
        {
            set { this.concretteColleague2 = value; }
        }


        public override void Send(string str, Colleague colleague)
        {
            if (colleague == concretteColleague1)
            {
                concretteColleague1.Notify(str);
            }
            else if (colleague == concretteColleague2)
            {
                concretteColleague2.Notify(str);
            }
        }






        static void Main_me(string[] str)
        {
            ConcreteMediator concreteMediator = new ConcreteMediator();

            ConcretteColleague1 colleague1 = new ConcretteColleague1(concreteMediator);
            ConcretteColleague2 colleague2 = new ConcretteColleague2(concreteMediator);

            concreteMediator.Colleague1 = colleague1;
            concreteMediator.Colleague2 = colleague2;

            colleague1.Send("别动代码！！别动代码！！别动代码！！动了会报错 我也不知道为啥");
            colleague2.Send("动了代码也没事  随边动");


        }
    }
}