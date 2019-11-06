
namespace ConsoleApp1 {

    /*public class Father {
        public void FatherMethod() {
            Console.Write("this property belongs to father");
        }
    }
    public class Child : Father {
        public void ChildMethod() {
            Console.Write("this property belongs to child");
        }
    }
    class Inheritence {
        static void Main(string[] args) {
            Father fobj = new Father();
            fobj.FatherMethod();

            Child cobj = new Child();
            cobj.ChildMethod();
            cobj.FatherMethod();
        }
    }
    */
}
    
    /*using System;
public class Exercise57{
    public static void Main(){
        string str, str1 = "";
        int i, l;


        Console.Write("\n\n");
        Console.Write("Print a string in reverse order:\n");
        Console.Write("----------------------------------");
        Console.Write("\n\n");
        Console.Write("Input  A String : ");
        str = Console.ReadLine();
        l = str.Length - 1;
        for (i = l; i >= 0; i--){
            str1 = str1 + str[i];


        }

        Console.WriteLine("The string in Reverse  Order Is : {0}", str1);
        Console.Write("\n");

    }
}*/

/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E07_CustomList.Models{
    public class CustomList<T>
        where T : IComparable{
        private List<T> list;
        public CustomList(){
            this.list = new List<T>();
        }
        private int Count => this.list.Count;
        private bool IsEmpty => this.Count == 0;
        public void Add(T element){
            this.list.Add(element);
        }
        public T Remove(int index){
            if (this.IsEmpty){
                throw new ArgumentException("Empty list!");
            }
            if (index < 0 || index > this.Count - 1){
                throw new ArgumentException("Invalid index!");
            }
            var removedElement = this.list[index];
            this.list.RemoveAt(index);
            return removedElement;
        }
        public bool Contains(T element){
            return this.list.Contains(element);
        }
        public void Swap(int index1, int index2){
            if (index1 < 0 || index1 > this.Count - 1 ||
                index2 < 0 || index2 > this.Count - 1){
                throw new ArgumentException("Invalid index!");
            }
            T swappedElement = this.list[index1];
            this.list[index1] = this.list[index2];
            this.list[index2] = swappedElement;
        }
        public int CountGreaterThan(T element){
            return this.list.Count(e => e.CompareTo(element) > 0);
        }
        public T Max(){
            if (this.IsEmpty){
                throw new ArgumentException("Empty list!");
            }
            return this.list.Max();
        }
        public T Min(){
            if (this.IsEmpty){
                throw new ArgumentException("Empty list!");
            }

            return this.list.Min();
        }
        public void Print(){
            foreach (var element in this.list){
                Console.WriteLine(element);
            }
        }
    }
}
public class Engine : IEngine{
    private const string TerminatingCommand = "Quit";
    private IInputReader reader;
    private IOutputWriter writer;
    private IManager heroManager;
    public Engine(IInputReader reader, IOutputWriter writer, IManager heroManager){
        this.reader = reader;
        this.writer = writer;
        this.heroManager = heroManager;
    }
    public void Run(){
        bool isRunning = true;
        while (isRunning){
            string inputLine = this.reader.ReadLine();
            IList<string> arguments = this.ParseInput(inputLine);
                 this.writer.WriteLine(this.ProcessInput(arguments));
                 isRunning = !this.ShouldEnd(inputLine); 
        }
    }
    private IList<string> ParseInput(string input){
        return input
        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .ToList();
    }
    private string ProcessInput(IList<string> arguments){
        string command = arguments[0];
        arguments.RemoveAt(0);
        // Invoke Command
        Type commandType = Assembly
                          .GetExecutingAssembly()
                          .GetTypes()
                          .FirstOrDefault(t => t.Name == command + "Command");
        var commandParams = new object[] { arguments, this.heroManager };
        ICommand cmd = (ICommand)Activator.CreateInstance(commandType, commandParams);
        //Type commandType = Type.GetType(command + "Command");
        //var constructor = commandType.GetConstructor(
        //                new Type[] { typeof(IList<string>), typeof(IManager) });
        //var commandParams = new object[] { arguments, this.heroManager };
        //ICommand cmd = (ICommand)constructor.Invoke(commandParams);
        return cmd.Execute();
    }
    private bool ShouldEnd(string inputLine){
        return inputLine.Equals(TerminatingCommand);
    }

/*namespace CopyPaste{
    public class CustomStack<T> : IEnumerable<T>{
        private IList<T> collection;
        public CustomStack(){
            this.collection = new List<T>();
        }
        public void Push(T element){
            this.collection.Add(element);
        }
        public T Pop(){
            if (this.collection.Count == 0){
                throw new InvalidOperationException("No elements");
            }
            var lastIndex = this.collection.Count - 1;
            var removedElement = this.collection[lastIndex];
            this.collection.RemoveAt(lastIndex);
            return removedElement;
        }
        public IEnumerator<T> GetEnumerator(){
            for (int i = this.collection.Count - 1; i >= 0; i--){
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
    */


    
  /*  class Program{
        static void Main(string[] args){
           /*onsole.WriteLine("Hello World!");
            Console.WriteLine("Mohammad Walihullah");
            int[] arr = new int[10];
            int i;
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");

            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++){
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++){
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");

        }
    }*/


