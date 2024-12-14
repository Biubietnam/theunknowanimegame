using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000B94 RID: 2964
	public static class MonthCardRewardNotifyReflection
	{
		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x06008367 RID: 33639 RVA: 0x0015AF78 File Offset: 0x00159178
		public static FileDescriptor Descriptor
		{
			get
			{
				return MonthCardRewardNotifyReflection.descriptor;
			}
		}

		// Token: 0x04003246 RID: 12870
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtNb250aENhcmRSZXdhcmROb3RpZnkucHJvdG8aDkl0ZW1MaXN0LnByb3Rv" + "IjIKFU1vbnRoQ2FyZFJld2FyZE5vdGlmeRIZCgZyZXdhcmQYCCABKAsyCS5J" + "dGVtTGlzdEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[]
		{
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MonthCardRewardNotify), MonthCardRewardNotify.Parser, new string[]
			{
				"Reward"
			}, null, null, null, null)
		}));
	}
}
