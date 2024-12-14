using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000A52 RID: 2642
	public static class LobbySyncInfoScNotifyReflection
	{
		// Token: 0x170020EC RID: 8428
		// (get) Token: 0x0600752C RID: 29996 RVA: 0x0013740E File Offset: 0x0013560E
		public static FileDescriptor Descriptor
		{
			get
			{
				return LobbySyncInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04002D13 RID: 11539
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtMb2JieVN5bmNJbmZvU2NOb3RpZnkucHJvdG8aFUxvYmJ5TW9kaWZ5VHlw",
			"ZS5wcm90bxoRQ0NIQ1BOTFBCREsucHJvdG8iZwoVTG9iYnlTeW5jSW5mb1Nj",
			"Tm90aWZ5EiEKC0VCTU9LUEJLTU1EGAogAygLMgwuQ0NIQ1BOTFBCREsSCwoD",
			"dWlkGAIgASgNEh4KBHR5cGUYDSABKA4yEC5Mb2JieU1vZGlmeVR5cGVCHqoC",
			"G0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			LobbyModifyTypeReflection.Descriptor,
			CCHCPNLPBDKReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(LobbySyncInfoScNotify), LobbySyncInfoScNotify.Parser, new string[]
			{
				"EBMOKPBKMMD",
				"Uid",
				"Type"
			}, null, null, null, null)
		}));
	}
}
