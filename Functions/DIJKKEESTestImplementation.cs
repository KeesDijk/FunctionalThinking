using System;
using System.Collections.Generic;
using System.Linq;
using Functions.Base;
using Functions.Helpers;
using Functions.Interfaces;

namespace Functions
{
    public class DIJKKEESTestImplementation : TestImplementationBase, ITestImplementation
    {
        public int IndexOfAny(string searchString, char[] charsToFind)
        {
            var result = -1;
            var indexedSearchString = Enumerable.Range(0, searchString.Length).Zip(searchString.ToArray(), (index,c) => new {index,c} );
            foreach (var indexpair in indexedSearchString)
            {
                if (charsToFind.Contains(indexpair.c))
                {
                    result = indexpair.index;
                    break;
                }
            }

            return 0;
        }

        public List<int> DeclarativeVsImperative(List<int> collection)
        {
            var results = collection.Where(num => num % 2 != 0).ToList();
            return results;
        }

        public void FunctionsAsVariablesOne(int a)
        {
            HandleExcptions(() =>
            {
                Log(string.Format("Starting processing with : {0}", a));
                DoComplicatedProcessing(a);
                Log("Done processing");
            });
        }

        public TestHelper FunctionsAsVariablesTwo(int nrOfUniqueItems)
        {
            var result = new TestHelper();

            FillListWithUniqueValues(nrOfUniqueItems, GetNextList1Item, result.List1);
            FillListWithUniqueValues(nrOfUniqueItems, GetNextList2Item, result.List2);
            FillListWithUniqueValues(nrOfUniqueItems, GetNextList3Item, result.List3);

            return result;
        }

        public IEnumerable<int> SimpleSelectFunction(List<int> input)
        {
            return input.Where(i => i > 10);
        }

        public IEnumerable<int> SlightlyLessSimpleSelectFunction(List<int> input, Func<int,bool> predicate)
        {
            return input.Where(predicate);
        }

        public IEnumerable<int> SimpleMapFunction(List<int> input)
        {
            return input.Select(x => x*2);
        }

        public IEnumerable<int> SlightlyLessSimpleMapFunction(List<int> input, Func<int, int> converterFunc)
        {
            return input.Select(converterFunc);
        }

        public int SimpleReduceFunction(List<int> input)
        {
            return input.Aggregate((result, i) => result + i);
        }

        public int SlightlyLessSimpleReduceFunction(List<int> input, int seed, Func<int, int, int> aggregateFunc)
        {
            return input.Aggregate(seed, aggregateFunc);
        }

        public List<int> FirstFiveIndexesOfFarInFarFarAway(List<string> text)
        {
            var enumerable = text
                .Select((word, index) => new { word, index})
                .Where(indexeword => indexeword.word.Equals("far", StringComparison.CurrentCultureIgnoreCase))
                .Select(indexword => indexword.index)
                .Take(5);
            return enumerable.ToList();
        }

        public int CallCounterNrOfTimes(int times)
        {
            int result = 0;
            var closureHelper = new ClosureHelper();
            for (int i = 0; i < times; i++)
            {
                var counterFunc = closureHelper.GetCounter();
                result = counterFunc();
            }
            return result;
        }

        private static void FillListWithUniqueValues(int nrOfUniqueItems, Func<string> getFunction, List<string> resultList)
        {
            var i = 0;
            var endlessLoopGuard = 0;

            while (i < nrOfUniqueItems && endlessLoopGuard < 10)
            {
                var nextList1Item = getFunction.Invoke();
                if (!resultList.Contains(nextList1Item))
                {
                    i++;
                    endlessLoopGuard = 0;
                    resultList.Add(nextList1Item);
                }
                else
                {
                    endlessLoopGuard++;
                }
            }
        }

        private void HandleExcptions(Action work)
        {
            try
            {
                work.Invoke();
            }
            catch (ArgumentException ea)
            {
                var msg = "Illigal Argument" + ea.Message;
                Log(msg, ea);
                throw;
            }
            catch (Exception e)
            {
                var msg = "Illigal Argument" + e.Message;
                Log(msg, e);
                throw;
            }
        }
    }
}
