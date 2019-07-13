using System.Collections.Generic;

namespace EldyState {

  public class Dictionary<T> {

    public class KeyValuePair {
      public string key;
      public T value;

      public KeyValuePair(string _k, T _v) {
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
      KeyValuePair kvp = retrieve(key);
      if (kvp == null) {
        return default(T);
      }

      return kvp.value;
    }
  }
}