using System.Threading.Tasks;

namespace Juniper.WinUI.App.Services;

public class SettingsService : ISettingsService
{
    /// <summary>
    /// The <see cref="IPropertySet"/> with the settings targeted by the current instance.
    /// </summary>
    private readonly IPropertySet SettingsStorage = ApplicationData.Current.LocalSettings.Values;

    /// <inheritdoc/>
    public void SetValue<T>(string key, T value)
    {
        if (!SettingsStorage.ContainsKey(key)) SettingsStorage.Add(key, value);
        else SettingsStorage[key] = value;
    }

    public async Task SetValueAsync<T>(string key, T value)
    {
        await Task.Run(() => 
        {
            if (!SettingsStorage.ContainsKey(key)) SettingsStorage.Add(key, value);
            else SettingsStorage[key] = value;
        });
    }

    /// <inheritdoc/>
    public T GetValue<T>(string key)
    {
        if (SettingsStorage.TryGetValue(key, out object value))
        {
            return (T)value;
        }

        return default;
    }

    public T GetValue<T>() => JsonSerializer.Deserialize<T>(GetValue<string>(typeof(T).Name)) ?? default;
    


    public async Task<string> GetStringValueAsync(string key)
    {
        if (SettingsStorage.ContainsKey(key))
        {
            return (string)await Task.Run(() =>
            {
                if (SettingsStorage.TryGetValue(key, out object value))
                {
                    return value;
                }
                return null;
            });
        }

        return null;
    }

    public async Task<T> GetValueAsync<T>(string key)
    {
        var jsonVal = await GetStringValueAsync(key);
        return jsonVal == null ? default : 
            (T)await Task.Run(() =>
            {
                return JsonSerializer.Deserialize<T>(jsonVal) ?? default;
            });
    }

    public async Task<T> GetValueAsync<T>() where T : class
    {
        return await GetValueAsync<T>(typeof(T).Name);
    }
}
