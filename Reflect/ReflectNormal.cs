using System;
using System.Reflection;

namespace Dotnet.Reflect
{
    public class ReflectNormal : ReflectBase
    {
        public override void Start()
        {
            base.Start();

            //获取类型对象
            Type personType = typeof(Person);
            Log.i(personType);

            Person person = new Person();
            personType = person.GetType();
            Log.i(personType);

            //对象的用处： 类属性  方法  构造函数  。。。。。。
            Log.i("获取类名: " + personType.Name);

            //ps:  ~~~~~~~`断点看log吧
            PropertyInfo[] infos = personType.GetProperties();
            if (infos != null && infos.Length > 0)
            {
                for (int i = 0; i < infos.Length; i++)
                {
                    Log.i(": " + infos[i].Name);
                }
            }
            PropertyInfo info1 = personType.GetProperty("Name");
            Log.i(info1.CanWrite);
            Log.i(info1.CanRead);
            object prop = info1.GetValue(person);
            info1.SetValue(person, "hahah");
            object prop1 = info1.GetValue(person);


            //~~~~~
            MethodInfo[] mothods = personType.GetMethods();
            MethodInfo method = personType.GetMethod("SayHi");
            if (method != null)
            {
                object objddd = method.Invoke(person, null);
                Log.i(objddd);
            }


            //通过反射获取一个类的对象
            //第一种形式
            Person person33 = Activator.CreateInstance<Person>();

            //第二种形式
            Type personType33 = typeof(Person);
            object p = Activator.CreateInstance(personType33);//使用无参构造函数
            p = Activator.CreateInstance(personType33, "小王", 19);//使用有参构造函数

            //第三种形式 
            ConstructorInfo[] contructors = personType.GetConstructors();//获取所有的构造函数 没多大用

            //获取单一的构造函数
            ConstructorInfo contructo = personType.GetConstructor(new[] { typeof(string), typeof(int) });

            object p3 = contructo.Invoke(new object[] { "234", 19 });



            LogEndTime();
        }


    }


    public class Person
    {
        public string Name { set; get; }
        public int Age { get; set; }


        public Person()
        {
            this.Name = "小李";
            this.Age = 66;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


        public string SayHi()
        {
            Log.i("滚滚滚");
            return "滚";
        }

    }


}