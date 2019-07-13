using System.Collections.Generic;

namespace EldyState {

  public class Dictionary<T> {

    public delegate void updateEvent(T value);

    public class KeyValue {
      public string key;
      public T value;

      public updateEvent updateEventHandler;

      public KeyValue(string _k, T _v) {
        key = _k;
        value = _v;
      }
    }

    List<KeyValue> dict = new List<KeyValue>();

    KeyValue retrieve(string key) {
      return dict.Find(x => x.key == key);
    }

    public void Set(string key, T value) {
      KeyValue kv = retrieve(key);
      if (kv != null) {
        kv.value = value;
        kv.updateEventHandler(value);
        return;
      }

      dict.Add(new KeyValue(key, value));
    }

    public T Get(string key) {
      KeyValue kv = retrieve(key);
      if (kv == null) {
        return default(T);
      }

      return kv.value;
    }

    public void AddEventToKey(string key, updateEvent fn) {
      KeyValue kv = retrieve(key);
      if (kv == null) {
        KeyValue newKv = new KeyValue(key, default(T));
        newKv.updateEventHandler += fn;
        dict.Add(newKv);
        return;
      }

      kv.updateEventHandler += fn;
    }
  }
}