namespace Juniper.Core.Util
{
    public class LoggerData
    {
        //public Exception Exception { get; set; }
        public string Method { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
    }
    public class LoggerDataList
    {
        public List<LoggerData> Exceptions { get; set; } = new List<LoggerData>();
    }

    public class LoggerUtil
    {
        public static LoggerUtil Current { get; private set; }

        public LoggerDataList ExceptionsList { get; set; } = new LoggerDataList();

        public LoggerUtil()
        {
            Current = this;
        }

        public async void AddException(Exception e, string method)
        {
            MainViewModel.Current.DisplayInfobarMessage("Error in " + method, e.Message.Length>500?e.Message.Remove(499):e.Message, InfoSeverity.Error);
            ExceptionsList.Exceptions.Add(new LoggerData()
            {
                Message = e.Message,
                StackTrace = e.StackTrace ?? "StackTrace null",
                Method = method,
            });

            try
            {
                var fs = MainViewModel.Current.FilesService;

                var fname = DateTime.Now.ToString("yyyy-MM-dd") + ".json";
                var fpath = Path.Combine(MainViewModel.Current.SettingsViewModel.SavedDataFilePath, fs.ErrorsFolder);
                await Task.Run(async () =>
                {
                    var i = 1;
                    var fullpath = Path.Combine(fpath, fname);
                    while (File.Exists(fullpath))
                    {
                        await Task.Delay(500);
                        fname = i + fname;
                        fullpath = Path.Combine(fpath, fname);
                    }
                });
                await fs.WriteAsync(fs.ErrorsFolder, fname, ExceptionsList, true);
            }
            catch { }
        }
    }
}