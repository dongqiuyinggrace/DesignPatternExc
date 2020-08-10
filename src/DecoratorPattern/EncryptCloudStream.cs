namespace DesignPatternExc.src.DecoratorPattern
{
    public class EncryptCloudStream : IStream
    {
        private readonly IStream _stream;
        public EncryptCloudStream(IStream stream)
        {
            _stream = stream;

        }
        public void Write(string data)
        {
            var encrypted = Encrypt(data);
            _stream.Write(encrypted);
        }

        private string Encrypt(string data)
        {
            return "#$^&(*))___))(*&^^*";
        }
    }
}