using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020003DC RID: 988
	public static class DressRelicParamReflection
	{
		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06002C00 RID: 11264 RVA: 0x0007A32E File Offset: 0x0007852E
		public static FileDescriptor Descriptor
		{
			get
			{
				return DressRelicParamReflection.descriptor;
			}
		}

		// Token: 0x040011C9 RID: 4553
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVEcmVzc1JlbGljUGFyYW0ucHJvdG8iPgoPRHJlc3NSZWxpY1BhcmFtEhcK" + "D3JlbGljX3VuaXF1ZV9pZBgLIAEoDRISCgpyZWxpY190eXBlGAMgASgNQh6q" + "AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(DressRelicParam), DressRelicParam.Parser, new string[]
			{
				"RelicUniqueId",
				"RelicType"
			}, null, null, null, null)
		}));
	}
}
