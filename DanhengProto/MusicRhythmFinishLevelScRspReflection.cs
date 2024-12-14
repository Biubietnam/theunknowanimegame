using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BDE RID: 3038
	public static class MusicRhythmFinishLevelScRspReflection
	{
		// Token: 0x170025B8 RID: 9656
		// (get) Token: 0x0600867F RID: 34431 RVA: 0x001630D1 File Offset: 0x001612D1
		public static FileDescriptor Descriptor
		{
			get
			{
				return MusicRhythmFinishLevelScRspReflection.descriptor;
			}
		}

		// Token: 0x04003389 RID: 13193
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFNdXNpY1JoeXRobUZpbmlzaExldmVsU2NSc3AucHJvdG8iQAobTXVzaWNS" + "aHl0aG1GaW5pc2hMZXZlbFNjUnNwEg8KB3JldGNvZGUYCSABKA0SEAoIbGV2" + "ZWxfaWQYBCABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmFinishLevelScRsp), MusicRhythmFinishLevelScRsp.Parser, new string[]
			{
				"Retcode",
				"LevelId"
			}, null, null, null, null)
		}));
	}
}
