using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000198 RID: 408
	public static class ChallengeBossInfoReflection
	{
		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x00034897 File Offset: 0x00032A97
		public static FileDescriptor Descriptor
		{
			get
			{
				return ChallengeBossInfoReflection.descriptor;
			}
		}

		// Token: 0x040007A9 RID: 1961
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdDaGFsbGVuZ2VCb3NzSW5mby5wcm90bxogQ2hhbGxlbmdlQm9zc0VxdWlw",
			"bWVudEluZm8ucHJvdG8aIkNoYWxsZW5nZUJvc3NBdmF0YXJSZWxpY0luZm8u",
			"cHJvdG8aIUNoYWxsZW5nZUJvc3NTaW5nbGVOb2RlSW5mby5wcm90byKsBAoR",
			"Q2hhbGxlbmdlQm9zc0luZm8SMQoLc2Vjb25kX25vZGUYDiABKAsyHC5DaGFs",
			"bGVuZ2VCb3NzU2luZ2xlTm9kZUluZm8SWwoeY2hhbGxlbmdlX2F2YXRhcl9l",
			"cXVpcG1lbnRfbWFwGAYgAygLMjMuQ2hhbGxlbmdlQm9zc0luZm8uQ2hhbGxl",
			"bmdlQXZhdGFyRXF1aXBtZW50TWFwRW50cnkSFAoMZmlyc3RfbGluZXVwGAUg",
			"AygNEhUKDXNlY29uZF9saW5ldXAYDSADKA0SEwoLQ1BOTUhOQUZESk0YByAB",
			"KAgSUwoaY2hhbGxlbmdlX2F2YXRhcl9yZWxpY19tYXAYASADKAsyLy5DaGFs",
			"bGVuZ2VCb3NzSW5mby5DaGFsbGVuZ2VBdmF0YXJSZWxpY01hcEVudHJ5EjAK",
			"CmZpcnN0X25vZGUYCCABKAsyHC5DaGFsbGVuZ2VCb3NzU2luZ2xlTm9kZUlu",
			"Zm8aXwogQ2hhbGxlbmdlQXZhdGFyRXF1aXBtZW50TWFwRW50cnkSCwoDa2V5",
			"GAEgASgNEioKBXZhbHVlGAIgASgLMhsuQ2hhbGxlbmdlQm9zc0VxdWlwbWVu",
			"dEluZm86AjgBGl0KHENoYWxsZW5nZUF2YXRhclJlbGljTWFwRW50cnkSCwoD",
			"a2V5GAEgASgNEiwKBXZhbHVlGAIgASgLMh0uQ2hhbGxlbmdlQm9zc0F2YXRh",
			"clJlbGljSW5mbzoCOAFCHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90",
			"b2IGcHJvdG8z"
		})), new FileDescriptor[]
		{
			ChallengeBossEquipmentInfoReflection.Descriptor,
			ChallengeBossAvatarRelicInfoReflection.Descriptor,
			ChallengeBossSingleNodeInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossInfo), ChallengeBossInfo.Parser, new string[]
			{
				"SecondNode",
				"ChallengeAvatarEquipmentMap",
				"FirstLineup",
				"SecondLineup",
				"CPNMHNAFDJM",
				"ChallengeAvatarRelicMap",
				"FirstNode"
			}, null, null, null, new GeneratedClrTypeInfo[2])
		}));
	}
}
