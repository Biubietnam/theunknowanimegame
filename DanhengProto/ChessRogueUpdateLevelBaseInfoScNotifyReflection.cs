using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002B2 RID: 690
	public static class ChessRogueUpdateLevelBaseInfoScNotifyReflection
	{
		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00058362 File Offset: 0x00056562
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChessRogueUpdateLevelBaseInfoScNotifyReflection.descriptor;
			}
		}

		// Token: 0x04000CD3 RID: 3283
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CitDaGVzc1JvZ3VlVXBkYXRlTGV2ZWxCYXNlSW5mb1NjTm90aWZ5LnByb3Rv",
			"GhtDaGVzc1JvZ3VlTGV2ZWxTdGF0dXMucHJvdG8aIUNoZXNzUm9ndWVVcGRh",
			"dGVMZXZlbFN0YXR1cy5wcm90byKDAQolQ2hlc3NSb2d1ZVVwZGF0ZUxldmVs",
			"QmFzZUluZm9TY05vdGlmeRIsCgxsZXZlbF9zdGF0dXMYDyABKA4yFi5DaGVz",
			"c1JvZ3VlTGV2ZWxTdGF0dXMSLAoGcmVhc29uGAwgASgOMhwuQ2hlc3NSb2d1",
			"ZVVwZGF0ZUxldmVsU3RhdHVzQh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIu",
			"UHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			ChessRogueLevelStatusReflection.Descriptor,
			ChessRogueUpdateLevelStatusReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChessRogueUpdateLevelBaseInfoScNotify), ChessRogueUpdateLevelBaseInfoScNotify.Parser, new string[]
			{
				"LevelStatus",
				"Reason"
			}, null, null, null, null)
		}));
	}
}
