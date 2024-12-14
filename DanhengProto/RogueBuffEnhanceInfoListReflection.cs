using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000E1A RID: 3610
	public static class RogueBuffEnhanceInfoListReflection
	{
		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x0600A146 RID: 41286 RVA: 0x001B06C7 File Offset: 0x001AE8C7
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueBuffEnhanceInfoListReflection.descriptor;
			}
		}

		// Token: 0x04004205 RID: 16901
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5Sb2d1ZUJ1ZmZFbmhhbmNlSW5mb0xpc3QucHJvdG8aGlJvZ3VlQnVmZkVu" + "aGFuY2VJbmZvLnByb3RvIkwKGFJvZ3VlQnVmZkVuaGFuY2VJbmZvTGlzdBIw" + "ChFlbmhhbmNlX2luZm9fbGlzdBgGIAMoCzIVLlJvZ3VlQnVmZkVuaGFuY2VJ" + "bmZvQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			RogueBuffEnhanceInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueBuffEnhanceInfoList), RogueBuffEnhanceInfoList.Parser, new string[]
			{
				"EnhanceInfoList"
			}, null, null, null, null)
		}));
	}
}
