namespace YellowBook.Services.Interfaces
{
    public interface IImageService
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        public String ConverteByteArrayToFile(byte[] fileData, string extension);



    }
}
