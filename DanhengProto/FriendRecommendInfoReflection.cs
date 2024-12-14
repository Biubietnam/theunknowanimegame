using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005C8 RID: 1480
	public static class FriendRecommendInfoReflection
	{
		// Token: 0x170012C2 RID: 4802
		// (get) Token: 0x06004206 RID: 16902 RVA: 0x000B3A75 File Offset: 0x000B1C75
		public static FileDescriptor Descriptor
		{
			get
			{
				return FriendRecommendInfoReflection.descriptor;
			}
		}

		// Token: 0x04001A35 RID: 6709
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlGcmllbmRSZWNvbW1lbmRJbmZvLnByb3RvGhZQbGF5ZXJTaW1wbGVJbmZv" + "LnByb3RvIlIKE0ZyaWVuZFJlY29tbWVuZEluZm8SEwoLTkJISUFERkVLRkYY" + "CyABKAgSJgoLcGxheWVyX2luZm8YDSABKAsyES5QbGF5ZXJTaW1wbGVJbmZv" + "Qh6qAhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[]
		{
			PlayerSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(FriendRecommendInfo), FriendRecommendInfo.Parser, new string[]
			{
				"NBHIADFEKFF",
				"PlayerInfo"
			}, null, null, null, null)
		}));
	}
}
