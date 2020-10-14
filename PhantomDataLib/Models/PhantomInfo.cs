using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

namespace PhantomLib.Models
{
    public class PhantomInfo
    {
        [AutoIncrement] [PrimaryKey] [Column("id")]
        public int Id { set; get; }
        [Column("server_name")]
        public string ServerName { set; get; }
        [Column("server_address")]
        public string ServerAddress { set; get; }
        [Column("server_port")] 
        public string ServerPort { set; get; }
        [Column("worker_threads")] 
        public string WorkerThreads { set; get; }
        [Column("ipv6")] 
        public bool Ipv6 { get; set; }
        [Column("debug")] 
        public bool Debug { get; set; }
        [Column("remove_ports")] 
        public bool RemovePorts { get; set; }
        [Column("timeout")] 
        public string Timeout { get; set; }
        [Column("bind")] 
        public string Bind { get; set; }
        [Column("bind_port")] 
        public string BindPort { get; set; }

        private static readonly Dictionary<string, string> PropertyParams = new Dictionary<string, string>
        {
            {"timeout", nameof(Timeout)},
            {"6", nameof(Ipv6)},
            {"debug", nameof(Debug)},
            {"remove_ports", nameof(RemovePorts)},
            {"bind", nameof(Bind)},
            {"bind_port", nameof(BindPort)}
        };

        public string AsParametersString()
        {
            var phantomOptions = new StringBuilder();
            phantomOptions.Append($"--server {ServerAddress}:{ServerPort} --workers {WorkerThreads}");

            foreach (var propertyParam in PropertyParams)
            {
                if (propertyParam.Value == nameof(Bind))
                {
                    phantomOptions.Append($"  --bind \"{Bind}\"");
                }
                else
                {
                    var phantomOption = typeof(PhantomInfo).GetProperty(propertyParam.Value)?.GetValue(this);
                    if (PhantomOptionIsValid(phantomOption))
                        phantomOptions.Append($"  --{propertyParam.Key} {phantomOption}");
                }
            }

            return phantomOptions.ToString().Trim().ToLower();
        }

        private static bool PhantomOptionIsValid(object option)
        {
            switch (option)
            {
                case string optionStr:
                    return string.IsNullOrEmpty(optionStr) == false;
                case bool optionBool:
                    return optionBool;
                default:
                    return false;
            }
        }
    }
}