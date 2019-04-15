using System;
using System.Collections.Generic;
namespace GraphAlgo
{
    public class Graph
    {
       List<LinkedList<int>> restaurants;

       public Graph()
       {
           restaurants = new List<LinkedList<int>>();
           intialize();
       }

       public void intialize()
       {
           for(int i =0; i<this.restaurants.Count;i++){
               restaurants[i] = new LinkedList<int>();
           }
       }

       public Graph addVertex(int input){
           LinkedList<int> toAdd = new LinkedList<int>();
           toAdd.AddLast(input);
           this.restaurants.Add(toAdd);
           return this;
       }

       public Graph connect(int input1, int input2)
       {
           if(!contains(input1)){this.addVertex(input1);}
           if(!contains(input2)){this.addVertex(input2);}
           this.addEdge(input1, input2);
           this.addEdge(input2, input1);
           return this;
       }

       private void addEdge(int start, int end)
       {
           for(int i = 0; i< this.restaurants.Count;i++)
           {
               if(restaurants[i].First.Value == start)
               {
                   restaurants[i].AddLast(end);
               }
           }
       }

       public bool contains(int input)
       {
           foreach(LinkedList<int> res in this.restaurants)
           {
               if(res.First.Value == input)
               {
                   return true;
               }
           }
           return false;
       }

       public bool isAdjacent(int start, int adjacent)
       {
           if(!this.contains(start)){return false;}
           if(!this.contains(adjacent)){return false;}           
           foreach(LinkedList<int> res in this.restaurants)
           {
               if(res.First.Value == start)
               {
                   LinkedListNode<int> runner = res.First.Next;
                   int count = 1;
                   while(count < res.Count)
                   {
                       if(runner.Value == adjacent)
                       {
                           return true;
                       }
                       count++;
                   }
               }                   
           }
           return false;
       }
    }
}
