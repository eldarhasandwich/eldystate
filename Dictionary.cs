using System.Collections.Generic;

namespace EldyState {
  public class Dictionary<T> {

    class KeyValuePair {
      public string key;
      public T value;

      KeyValuePair(string _k, T _v) {
        key = _k;
        value = _v;
      }
    }

    List<KeyValuePair> dict = new List<KeyValuePair>();

    KeyValuePair retrieve(string key) {
      return dict.Find(x => x.key == key);
    }

    public void Set(string key, T value) {
      KeyValuePair kvp = retrieve(key);
      if (kvp != null) {
        kvp.value = value;
        return;
      }

      dict.Add(new KeyValuePair(key, value));
    }

    public T Get(string key) {
      return retrieve(key);
    }
  }
}