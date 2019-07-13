using System;
using System.Collections;

namespace EldyState {
  class Program {

    static void Main(string[] args) {
      Dictionary<int> bDict = new Dictionary<int>();

      bDict.Set("my face", 60);
      bDict.Set("my other face", 60);

      Console.WriteLine(bDict.Get("not my face"));
      Console.WriteLine(bDict.Get("my other face"));
      Console.WriteLine(bDict.Get("my face"));
    }
  }
}
