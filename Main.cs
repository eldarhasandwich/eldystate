using System;
using System.Collections;

namespace EldyState {
  class Program {

    static void Main(string[] args) {
      Dictionary<int> bDict = new Dictionary<int>();

      bDict.Set("my face", 60);
  
      bDict.AddEventToKey("my face", () => {
        Console.WriteLine("Updated thing");
      });

      bDict.Set("my face", 100);

    }
  }
}
