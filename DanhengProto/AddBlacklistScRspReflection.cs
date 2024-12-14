using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000042 RID: 66
	public static class AddBlacklistScRspReflection
	{
		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00008486 File Offset: 0x00006686
		public static FileDescriptor Descriptor
		{
			get
			{
				return AddBlacklistScRspReflection.descriptor;
			}
		}

		// Token: 0x040000EF RID: 239
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdBZGRCbGFja2xpc3RTY1JzcC5wcm90bxoWUGxheWVyU2ltcGxlSW5mby5w" + "cm90byJLChFBZGRCbGFja2xpc3RTY1JzcBIPCgdyZXRjb2RlGAggASgNEiUK" + "CmJsYWNrX2luZm8YDSABKAsyES5QbGF5ZXJTaW1wbGVJbmZvQh6qAhtFZ2dM" + "aW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			PlayerSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(AddBlacklistScRsp), AddBlacklistScRsp.Parser, new string[]
			{
				"Retcode",
				"BlackInfo"
			}, null, null, null, null)
		}));
	}
}
