using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000DDA RID: 3546
	public static class ReturnLastTownScRspReflection
	{
		// Token: 0x17002CB9 RID: 11449
		// (get) Token: 0x06009E78 RID: 40568 RVA: 0x001A7E2A File Offset: 0x001A602A
		public static FileDescriptor Descriptor
		{
			get
			{
				return ReturnLastTownScRspReflection.descriptor;
			}
		}

		// Token: 0x04004104 RID: 16644
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlSZXR1cm5MYXN0VG93blNjUnNwLnByb3RvGg9TY2VuZUluZm8ucHJvdG8i" + "QQoTUmV0dXJuTGFzdFRvd25TY1JzcBIZCgVzY2VuZRgLIAEoCzIKLlNjZW5l" + "SW5mbxIPCgdyZXRjb2RlGAggASgNQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2" + "ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			SceneInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ReturnLastTownScRsp), ReturnLastTownScRsp.Parser, new string[]
			{
				"Scene",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
