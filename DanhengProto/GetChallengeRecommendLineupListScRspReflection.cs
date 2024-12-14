using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000646 RID: 1606
	public static class GetChallengeRecommendLineupListScRspReflection
	{
		// Token: 0x17001491 RID: 5265
		// (get) Token: 0x06004819 RID: 18457 RVA: 0x000C5426 File Offset: 0x000C3626
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetChallengeRecommendLineupListScRspReflection.descriptor;
			}
		}

		// Token: 0x04001CD0 RID: 7376
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CipHZXRDaGFsbGVuZ2VSZWNvbW1lbmRMaW5ldXBMaXN0U2NSc3AucHJvdG8a",
			"EUVBQ0lOSENDQ01JLnByb3RvInAKJEdldENoYWxsZW5nZVJlY29tbWVuZExp",
			"bmV1cExpc3RTY1JzcBIhCgtQUEFHR09ORFBDRhgFIAMoCzIMLkVBQ0lOSEND",
			"Q01JEg8KB3JldGNvZGUYDCABKA0SFAoMY2hhbGxlbmdlX2lkGAYgASgNQh6q",
			"AhtFZ2dMaW5rLkRhbmhlbmdTZXJ2ZXIuUHJvdG9iBnByb3RvMw=="
		})), new FileDescriptor[]
		{
			EACINHCCCMIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetChallengeRecommendLineupListScRsp), GetChallengeRecommendLineupListScRsp.Parser, new string[]
			{
				"PPAGGONDPCF",
				"Retcode",
				"ChallengeId"
			}, null, null, null, null)
		}));
	}
}
