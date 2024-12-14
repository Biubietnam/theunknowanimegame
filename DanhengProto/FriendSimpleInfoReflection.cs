using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005CA RID: 1482
	public static class FriendSimpleInfoReflection
	{
		// Token: 0x170012C8 RID: 4808
		// (get) Token: 0x0600421D RID: 16925 RVA: 0x000B3E00 File Offset: 0x000B2000
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendSimpleInfoReflection.descriptor;
			}
		}

		// Token: 0x04001A3C RID: 6716
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChZGcmllbmRTaW1wbGVJbmZvLnByb3RvGhZQbGF5ZXJTaW1wbGVJbmZvLnBy",
			"b3RvGhFOQUFKS0xNTklKSS5wcm90bxoSUGxheWluZ1N0YXRlLnByb3RvIsAB",
			"ChBGcmllbmRTaW1wbGVJbmZvEhMKC3JlbWFya19uYW1lGAwgASgJEiYKC3Bs",
			"YXllcl9pbmZvGAggASgLMhEuUGxheWVyU2ltcGxlSW5mbxIRCglpc19tYXJr",
			"ZWQYCyABKAgSJAoNcGxheWluZ19zdGF0ZRgHIAEoDjINLlBsYXlpbmdTdGF0",
			"ZRIhCgtFRkFFQUxLRUlQRBgNIAEoCzIMLk5BQUpLTE1OSUpJEhMKC2NyZWF0",
			"ZV90aW1lGAYgASgDQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9i",
			"BnByb3RvMw=="
		})), new FileDescriptor[]
		{
			PlayerSimpleInfoReflection.Descriptor,
			NAAJKLMNIJIReflection.Descriptor,
			PlayingStateReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendSimpleInfo), FriendSimpleInfo.Parser, new string[]
			{
				"RemarkName",
				"PlayerInfo",
				"IsMarked",
				"PlayingState",
				"EFAEALKEIPD",
				"CreateTime"
			}, null, null, null, null)
		}));
	}
}
