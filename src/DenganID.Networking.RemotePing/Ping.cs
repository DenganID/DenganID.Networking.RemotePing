namespace DenganID.Networking.RemotePing
{
    public class Ping
    {
        public bool IsAlive(string host)
        {
            var isAlive = false;

            try {
                var ping = new System.Net.NetworkInformation.Ping();
                var result = ping.Send(host);
                if (result.Status == System.Net.NetworkInformation.IPStatus.Success) {
                    isAlive = true;
                }
                
            } catch {
                isAlive = false;
            }

            return isAlive;
        }
    }
}
