using System;
using System.Collections.Generic;
using System.Linq;
using Linq.Objects;

namespace Linq
{
    public static class Tasks
    {
        
        public static string TaskExample(IEnumerable<string> stringList)
        {
            return stringList.Aggregate<string>((x, y) => x + y);
        }

        #region Low

        public static IEnumerable<string> Task1(char c, IEnumerable<string> stringList)
        {
            return stringList.Where<string>(item => item.Length > 1 && item.StartsWith(c) && item.EndsWith(c));
        }

        public static IEnumerable<int> Task2(IEnumerable<string> stringList)
        {
            return stringList.Select(item => item.Length).OrderBy(item => item);
        }

        public static IEnumerable<string> Task3(IEnumerable<string> stringList)
        {
            return stringList.Select(item => item.First().ToString() + item.Last());
        }

        public static IEnumerable<string> Task4(int k, IEnumerable<string> stringList)
        {
            return stringList.Where(item => item.Length == k && Char.IsNumber(item.Last())).OrderBy(item => item);
        }

        public static IEnumerable<string> Task5(IEnumerable<int> integerList)
        {
            return integerList.Where(item => item % 2 != 0).OrderBy(item => item).Select(item => item.ToString());
        }

        #endregion
        #region Middle

        public static IEnumerable<string> Task6(IEnumerable<int> numbers, IEnumerable<string> stringList)
        {
            return numbers.Select(n => stringList.Where(item => item.Length == n && Char.IsNumber(item.First())).FirstOrDefault() ?? "Not found");
        }

        public static IEnumerable<int> Task7(int k, IEnumerable<int> integerList)
        {
            return integerList.Where(item => item % 2 == 0).Except(integerList.Skip(k)).Reverse();
        }

        public static IEnumerable<int> Task8(int k, int d, IEnumerable<int> integerList)
        {
            return integerList.TakeWhile(item => item <= d).Union(integerList.Skip(k)).OrderByDescending(item => item);
        }

        public static IEnumerable<string> Task9(IEnumerable<string> stringList)
        {
            return stringList.Aggregate(new Dictionary<char, int>(), (acc, item) =>
            {
                char firstLetter = item[0];
                if (acc.ContainsKey(firstLetter))
                {
                    acc[firstLetter] += item.Length;
                } else
                {
                    acc[firstLetter] = item.Length;
                }
                return acc;
            })
                .OrderBy(kv => kv.Key)
                .OrderByDescending(kv => kv.Value)
                .Select(kv => $"{kv.Value}-{kv.Key}");
        }


        public static IEnumerable<string> Task10(IEnumerable<string> stringList)
        {
            return stringList.GroupBy(i => i.Length, (key, g) => new { Count = key, Words = g.OrderBy(i => i).ToList() })
                 .Select(item => item.Words.Aggregate("", (acc, y) => acc + y.Last().ToString().ToUpper()))
                 .OrderByDescending(item => item.Length);
              
        }

        #endregion

        #region Advance

        public static IEnumerable<YearSchoolStat> Task11(IEnumerable<Entrant> nameList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<NumberPair> Task12(IEnumerable<int> integerList1, IEnumerable<int> integerList2)
        {
            //TODO :Delete line below and write your own solution
            throw new NotImplementedException();
        }

        public static IEnumerable<YearSchoolStat> Task13(IEnumerable<Entrant> nameList, IEnumerable<int> yearList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<MaxDiscountOwner> Task14(IEnumerable<Supplier> supplierList,
                IEnumerable<SupplierDiscount> supplierDiscountList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        public static IEnumerable<CountryStat> Task15(IEnumerable<Good> goodList,
            IEnumerable<StorePrice> storePriceList)
        {
            //TODO :Delete line below and write your own solution 
            throw new NotImplementedException();
        }

        #endregion

    }
}
