using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001346 RID: 4934
	public static class TeleportToMissionResetPointScRspReflection
	{
		// Token: 0x17003DDA RID: 15834
		// (get) Token: 0x0600DC37 RID: 56375 RVA: 0x0024A546 File Offset: 0x00248746
		public static FileDescriptor Descriptor
		{
			get
			{
				return TeleportToMissionResetPointScRspReflection.descriptor;
			}
		}

		// Token: 0x0400579C RID: 22428
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiZUZWxlcG9ydFRvTWlzc2lvblJlc2V0UG9pbnRTY1JzcC5wcm90bxoQTW90",
			"aW9uSW5mby5wcm90byJsCiBUZWxlcG9ydFRvTWlzc2lvblJlc2V0UG9pbnRT",
			"Y1JzcBIaChJjbGllbnRfcG9zX3ZlcnNpb24YBSABKA0SGwoGbW90aW9uGA4g",
			"ASgLMgsuTW90aW9uSW5mbxIPCgdyZXRjb2RlGAogASgNQh6qAhtFZ2dMaW5r",
			"LkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(TeleportToMissionResetPointScRsp), TeleportToMissionResetPointScRsp.Parser, new string[]
			{
				"ClientPosVersion",
				"Motion",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
