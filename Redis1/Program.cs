using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;
namespace Redis1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConnectionMultiplexer redisConn = ConnectionMultiplexer.Connect("localhost");
            IDatabase redis = redisConn.GetDatabase();
             // var redis = RedisStore.RedisCache;

                var listKey = "listKey";

                redis.KeyDelete(listKey, CommandFlags.FireAndForget);

                redis.ListRightPush(listKey, "a");

                var len = redis.ListLength(listKey);
                Console.WriteLine(len); //output  is 1

                redis.ListRightPush(listKey, "b");

                Console.WriteLine(redis.ListLength(listKey)); 

                //lets clear it out
                redis.KeyDelete(listKey, CommandFlags.FireAndForget);

                redis.ListRightPush(listKey, "moohsina habeeba is typing the code".Select(x => (RedisValue)x.ToString()).ToArray());

                Console.WriteLine(redis.ListLength(listKey)); 

                Console.WriteLine(string.Concat(redis.ListRange(listKey))); 

                var lastFive = redis.ListRange(listKey, -5);

                Console.WriteLine(string.Concat(lastFive)); 
                var firstFive = redis.ListRange(listKey, 0, 4);

                Console.WriteLine(string.Concat(firstFive)); 

                redis.ListTrim(listKey, 0, 1);

                Console.WriteLine(string.Concat(redis.ListRange(listKey))); 

                
                redis.KeyDelete(listKey, CommandFlags.FireAndForget);

                redis.ListRightPush(listKey, "mohsina is not typing".Select(x => (RedisValue)x.ToString()).ToArray());

                var firstElement = redis.ListLeftPop(listKey);

                Console.WriteLine(firstElement); 

                var lastElement = redis.ListRightPop(listKey);

                Console.WriteLine(lastElement); 

                redis.ListRemove(listKey, "c");

                Console.WriteLine(string.Concat(redis.ListRange(listKey))); 
                redis.ListSetByIndex(listKey, 1, "c");

                Console.WriteLine(string.Concat(redis.ListRange(listKey)));   

                var thirdItem = redis.ListGetByIndex(listKey, 3);

                Console.WriteLine(thirdItem); //output f  

                //lets clear it out
                var destinationKey = "destinationList";
                redis.KeyDelete(listKey, CommandFlags.FireAndForget);
                redis.KeyDelete(destinationKey, CommandFlags.FireAndForget);

                redis.ListRightPush(listKey, "she is going to type".Select(x => (RedisValue)x.ToString()).ToArray());

                var listLength = redis.ListLength(listKey);

                for (var i = 0; i < listLength; i++)
                {
                    var val = redis.ListRightPopLeftPush(listKey, destinationKey);

                    Console.Write(val);
            }

                
            
        
        /*var hashKey = "hashKey";
        HashEntry[] redisBookHash = {
new HashEntry("title", "Redis for C# Developers"),
new HashEntry("year", 2016),
new HashEntry("author", "mohsina habeeba")
};

        redis.HashSet(hashKey, redisBookHash);

        if (redis.HashExists(hashKey, "year"))
        {
            var year = redis.HashGet(hashKey, "year"); 
        }

        var allHash = redis.HashGetAll(hashKey);


        foreach (var item in allHash)
        {

            Console.WriteLine(string.Format("key : {0}, value : {1}", item.Name, item.Value));
        }


        var values = redis.HashValues(hashKey);

        foreach (var val in values)
        {
            Console.WriteLine(val);
        }


        var keys = redis.HashKeys(hashKey);

        foreach (var k in keys)
        {
            Console.WriteLine(k);
        }

        var len = redis.HashLength(hashKey);  

        if (redis.HashExists(hashKey, "year"))
        {
            var year = redis.HashIncrement(hashKey, "year", 1); //year now becomes 2017
            var year2 = redis.HashDecrement(hashKey, "year", 1.5); //year now becomes 2015.5
            Console.WriteLine(year);
            Console.WriteLine(year2);
        }*/
        //redDb.StringSet("key2", "value2");
        // Console.WriteLine(redDb.StringGet("key2"));
        // redDb.HashSet("user:user1", new HashEntry[] { new HashEntry("12", "13"), new HashEntry("14", "15") });
        //  Console.WriteLine(redDb.HashGet("user","user1"));
        Console.ReadLine();
        }
    }
}

