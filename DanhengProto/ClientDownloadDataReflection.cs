using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002D4 RID: 724
	public static class ClientDownloadDataReflection
	{
		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x0005BD02 File Offset: 0x00059F02
		public static FileDescriptor Descriptor
		{
			get
			{
				return ClientDownloadDataReflection.descriptor;
			}
		}

		// Token: 0x04000D58 RID: 3416
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDbGllbnREb3dubG9hZERhdGEucHJvdG8iQQoSQ2xpZW50RG93bmxvYWRE" + "YXRhEg8KB3ZlcnNpb24YASABKA0SDAoEdGltZRgCIAEoAxIMCgRkYXRhGAMg" + "ASgMQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ClientDownloadData), ClientDownloadData.Parser, new string[]
			{
				"Version",
				"Time",
				"Data"
			}, null, null, null, null)
		}));
	}
}
