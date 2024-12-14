using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000944 RID: 2372
	public static class IPCMEMCHCPIReflection
	{
		// Token: 0x17001DC6 RID: 7622
		// (get) Token: 0x060069E7 RID: 27111 RVA: 0x0011A973 File Offset: 0x00118B73
		public static FileDescriptor Descriptor
		{
			get
			{
				return IPCMEMCHCPIReflection.descriptor;
			}
		}

		// Token: 0x04002890 RID: 10384
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJUENNRU1DSENQSS5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJCCgtJUENN" + "RU1DSENQSRIRCglhdmF0YXJfaWQYBiABKA0SIAoLYXZhdGFyX3R5cGUYDiAB" + "KA4yCy5BdmF0YXJUeXBlQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			AvatarTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(IPCMEMCHCPI), IPCMEMCHCPI.Parser, new string[]
			{
				"AvatarId",
				"AvatarType"
			}, null, null, null, null)
		}));
	}
}
