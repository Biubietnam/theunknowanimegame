using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000EE6 RID: 3814
	public static class RogueMagicLayerInfoReflection
	{
		// Token: 0x17003028 RID: 12328
		// (get) Token: 0x0600AA86 RID: 43654 RVA: 0x001CB61C File Offset: 0x001C981C
		public static FileDescriptor Descriptor
		{
			get
			{
				return RogueMagicLayerInfoReflection.descriptor;
			}
		}

		// Token: 0x04004598 RID: 17816
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChlSb2d1ZU1hZ2ljTGF5ZXJJbmZvLnByb3RvGhhSb2d1ZU1hZ2ljUm9vbUlu",
			"Zm8ucHJvdG8aG1JvZ3VlTWFnaWNMYXllclN0YXR1cy5wcm90byKqAQoTUm9n",
			"dWVNYWdpY0xheWVySW5mbxIsCg90b3Vybl9yb29tX2xpc3QYDiADKAsyEy5S",
			"b2d1ZU1hZ2ljUm9vbUluZm8SEwoLbGV2ZWxfaW5kZXgYASABKA0SEAoIbGF5",
			"ZXJfaWQYDSABKA0SFgoOY3VyX3Jvb21faW5kZXgYCCABKA0SJgoGc3RhdHVz",
			"GAwgASgOMhYuUm9ndWVNYWdpY0xheWVyU3RhdHVzQh6qAhtFZ2dMaW5rLkRh",
			"bmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			RogueMagicRoomInfoReflection.Descriptor,
			RogueMagicLayerStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(RogueMagicLayerInfo), RogueMagicLayerInfo.Parser, new string[]
			{
				"TournRoomList",
				"LevelIndex",
				"LayerId",
				"CurRoomIndex",
				"Status"
			}, null, null, null, null)
		}));
	}
}
