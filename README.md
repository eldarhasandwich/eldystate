# eldystate

Util class for global state in Unity C#

## Todo;
- Replace generic `List<T>` with a hashmap
- Static class to access state wherever

### Dictionary

```cs
void Set(string key, T value);
```

```cs
void Get<T>(string value);
```

```cs
void AddEventToKey(string key, ()=>{});
```