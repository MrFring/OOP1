using Newtonsoft.Json;
using SquirrelFramework.Domain.Model;
using SquirrelFramework.Repository;
using System;
using System.ComponentModel;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            People hahaha = new People();
            hahaha.Age = 18;
            People xiaohong = new People();

            xiaohong.Age = 19;
            People ahahaha = new People();
            ahahaha.Age = 15;

            PeopleCurdRepository database = new PeopleCurdRepository(); //step3
            database.Add(hahaha);
            database.Add(xiaohong);
            database.Add(ahahaha);

            Console.WriteLine(JsonConvert.SerializeObject(database.GetAll()));

            //序列化
            //Console.WriteLine(JsonConvert.SerializeObject(hahaha));
            //反序列化
            //People hahaha2 = JsonConvert.DeserializeObject<People>(JsonConvert.SerializeObject(hahaha));//深拷贝
        }

        class PeopleCurdRepository : RepositoryBase<People> { } //step2

        class People : DomainModel //step1
        {
            public People()
            {

            }
            //成员方法 行为
            public void Eat(int foodSize)
            {
                HungerIndex += foodSize / 2;
            }
            //成员变量 属性
            int HungerIndex;
            public string IdNumber;    // 唯一标识符
            public string Name;
            public bool Gender;
            public int Age;
            public DateTime Birthday;
            public string Profession;
        }
    }
}
