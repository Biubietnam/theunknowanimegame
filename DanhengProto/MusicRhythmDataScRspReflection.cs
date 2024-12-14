using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000BDA RID: 3034
	public static class MusicRhythmDataScRspReflection
	{
		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x06008648 RID: 34376 RVA: 0x00162506 File Offset: 0x00160706
		public static FileDescriptor Descriptor
		{
			get
			{
				return MusicRhythmDataScRspReflection.descriptor;
			}
		}

		// Token: 0x04003368 RID: 13160
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChpNdXNpY1JoeXRobURhdGFTY1JzcC5wcm90bxoWTXVzaWNSaHl0aG1MZXZl",
			"bC5wcm90bxoWTXVzaWNSaHl0aG1Hcm91cC5wcm90byKFAgoUTXVzaWNSaHl0",
			"aG1EYXRhU2NSc3ASGAoQdW5sb2NrX3NvbmdfbGlzdBgPIAMoDRITCgtjdXJf",
			"c29uZ19pZBgCIAEoDRIZChF1bmxvY2tfdHJhY2tfbGlzdBgIIAMoDRIZChF1",
			"bmxvY2tfcGhhc2VfbGlzdBgFIAMoDRIRCglzaG93X2hpbnQYBiABKAgSJgoL",
			"bXVzaWNfZ3JvdXAYASADKAsyES5NdXNpY1JoeXRobUdyb3VwEiYKC211c2lj",
			"X2xldmVsGA0gAygLMhEuTXVzaWNSaHl0aG1MZXZlbBIUCgxjdXJfbGV2ZWxf",
			"aWQYCiABKA0SDwoHcmV0Y29kZRgMIAEoDUIeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			MusicRhythmLevelReflection.Descriptor,
			MusicRhythmGroupReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmDataScRsp), MusicRhythmDataScRsp.Parser, new string[]
			{
				"UnlockSongList",
				"CurSongId",
				"UnlockTrackList",
				"UnlockPhaseList",
				"ShowHint",
				"MusicGroup",
				"MusicLevel",
				"CurLevelId",
				"Retcode"
			}, null, null, null, null)
		}));
	}
}
