using System;
using System.Collections;

namespace EldyState {
  class Program {

    static void Main(string[] args) {
      Dictionary<int> intDict = new Dictionary<int>();

      intDict.Set("my face", 60);
  
      intDict.AddEventToKey("my face", () => {
        Console.WriteLine("Updated thing");
      });

      intDict.Set("my face", 100);

    }
  }
}
