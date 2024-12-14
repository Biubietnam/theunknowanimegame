using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x0200077A RID: 1914
	public static class GetPunkLordBattleRecordScRspReflection
	{
		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x06005589 RID: 21897 RVA: 0x000E5AF9 File Offset: 0x000E3CF9
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetPunkLordBattleRecordScRspReflection.descriptor;
			}
		}

		// Token: 0x04002184 RID: 8580
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"CiJHZXRQdW5rTG9yZEJhdHRsZVJlY29yZFNjUnNwLnByb3RvGhhQdW5rTG9y",
			"ZE1vbnN0ZXJLZXkucHJvdG8aGlB1bmtMb3JkQmF0dGxlUmVjb3JkLnByb3Rv",
			"GhpQdW5rTG9yZEJhdHRsZVJlcGxheS5wcm90byK4AQocR2V0UHVua0xvcmRC",
			"YXR0bGVSZWNvcmRTY1JzcBIxChJiYXR0bGVfcmVjb3JkX2xpc3QYASADKAsy",
			"FS5QdW5rTG9yZEJhdHRsZVJlY29yZBIPCgdyZXRjb2RlGA4gASgNEigKC0xF",
			"SFBKTEZOT05FGAIgASgLMhMuUHVua0xvcmRNb25zdGVyS2V5EioKC0lBSkVL",
			"RU1JSkZBGAsgAygLMhUuUHVua0xvcmRCYXR0bGVSZXBsYXlCHqoCG0VnZ0xp",
			"bmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			PunkLordMonsterKeyReflection.Descriptor,
			PunkLordBattleRecordReflection.Descriptor,
			PunkLordBattleReplayReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetPunkLordBattleRecordScRsp), GetPunkLordBattleRecordScRsp.Parser, new string[]
			{
				"BattleRecordList",
				"Retcode",
				"LEHPJLFNONE",
				"IAJEKEMIJFA"
			}, null, null, null, null)
		}));
	}
}
