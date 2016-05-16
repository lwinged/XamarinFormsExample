using System;
using PCLStorage;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace XamTest
{
	public class FileStorage
	{
		static string subFolderName = "MySubFolder";
		static string fileName = "myfile.json";

		public FileStorage ()
		{
		}

		public static async Task saveFile<T>(T value)
		{
			IFolder rootFolder = FileSystem.Current.LocalStorage;
			IFolder folder = await rootFolder.CreateFolderAsync(subFolderName,
				CreationCollisionOption.OpenIfExists);
			IFile file = await folder.CreateFileAsync(fileName,
				CreationCollisionOption.ReplaceExisting);

			var content = JsonConvert.SerializeObject (value);
			await file.WriteAllTextAsync(content);
		}
			
		public static async Task<T> readFile<T>()
		{
			IFolder rootFolder = FileSystem.Current.LocalStorage;
			IFolder folder = await rootFolder.CreateFolderAsync(subFolderName,
				CreationCollisionOption.OpenIfExists);
			IFile file = await folder.CreateFileAsync(fileName,
				CreationCollisionOption.OpenIfExists);

			var content = await file.ReadAllTextAsync();
			var p = JsonConvert.DeserializeObject<T>(content);

			return p;
		}
	}
}

