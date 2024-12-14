using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006A6 RID: 1702
	public static class GetFightFestDataScRspReflection
	{
		// Token: 0x170015A6 RID: 5542
		// (get) Token: 0x06004C36 RID: 19510 RVA: 0x000CEC12 File Offset: 0x000CCE12
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetFightFestDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04001E27 RID: 7719
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChtHZXRGaWdodEZlc3REYXRhU2NSc3AucHJvdG8aEUpNREFFQkZITkFJLnBy",
			"b3RvIokBChVHZXRGaWdodEZlc3REYXRhU2NSc3ASEAoIc2NvcmVfaWQYCCAB",
			"KA0SEwoLSkpJUEpCRUFKSUgYCiADKA0SEgoKaXRlbV92YWx1ZRgEIAEoDRIk",
			"Cg5jaGFsbGVuZ2VfbGlzdBgFIAMoCzIMLkpNREFFQkZITkFJEg8KB3JldGNv",
			"ZGUYByABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[]
		{
			JMDAEBFHNAIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetFightFestDataScRsp), GetFightFestDataScRsp.Parser, new string[]
			{
				"ScoreId",
				"JJIPJBEAJIH",
				"ItemValue",
				"ChallengeList",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
