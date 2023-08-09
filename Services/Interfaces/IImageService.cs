namespace YellowBook.Services.Interfaces
{
    public interface IImageService
    {
        public Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        public String ConvertByteArrayToFile(byte[] fileData, string extension);



    }
}
