using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D26 RID: 3366
	public static class PunkLordMonsterBasicInfoReflection
	{
		// Token: 0x17002A69 RID: 10857
		// (get) Token: 0x06009665 RID: 38501 RVA: 0x00190088 File Offset: 0x0018E288
		public static FileDescriptor Descriptor
		{
			get
			{
				return PunkLordMonsterBasicInfoReflection.descriptor;
			}
		}

		// Token: 0x04003A53 RID: 14931
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"Ch5QdW5rTG9yZE1vbnN0ZXJCYXNpY0luZm8ucHJvdG8aF1B1bmtMb3JkU2hh",
			"cmVUeXBlLnByb3RvItwBChhQdW5rTG9yZE1vbnN0ZXJCYXNpY0luZm8SCwoD",
			"dWlkGAEgASgNEhIKCm1vbnN0ZXJfaWQYAiABKA0SEQoJY29uZmlnX2lkGAMg",
			"ASgNEhMKC3dvcmxkX2xldmVsGAQgASgNEhMKC2NyZWF0ZV90aW1lGAUgASgD",
			"Eg8KB2xlZnRfaHAYBiABKA0SFAoMYXR0YWNrZXJfbnVtGAcgASgNEiYKCnNo",
			"YXJlX3R5cGUYCCABKA4yEi5QdW5rTG9yZFNoYXJlVHlwZRITCgtNTUJBT0NH",
			"RkJMSRgJIAEoCEIeqgIbRWdnTGluay5EYW5oZW5nU2VydmVyLlByb3RvYgZw",
			"cm90bzM="
		})), new FileDescriptor[]
		{
			PunkLordShareTypeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(PunkLordMonsterBasicInfo), PunkLordMonsterBasicInfo.Parser, new string[]
			{
				"Uid",
				"MonsterId",
				"ConfigId",
				"WorldLevel",
				"CreateTime",
				"LeftHp",
				"AttackerNum",
				"ShareType",
				"MMBAOCGFBLI"
			}, null, null, null, null)
		}));
	}
}
