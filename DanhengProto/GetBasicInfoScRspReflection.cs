using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000630 RID: 1584
	public static class GetBasicInfoScRspReflection
	{
		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x06004718 RID: 18200 RVA: 0x000C2C7E File Offset: 0x000C0E7E
		public static FileDescriptor Descriptor
		{
			get
			{
				return GetBasicInfoScRspReflection.descriptor;
			}
		}

		// Token: 0x04001C7A RID: 7290
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChdHZXRCYXNpY0luZm9TY1JzcC5wcm90bxoXUGxheWVyU2V0dGluZ0luZm8u",
			"cHJvdG8inwIKEUdldEJhc2ljSW5mb1NjUnNwEhUKDWlzX2dlbmRlcl9zZXQY",
			"AyABKAgSDwoHY3VyX2RheRgLIAEoDRIWCg5leGNoYW5nZV90aW1lcxgOIAEo",
			"DRIvChNwbGF5ZXJfc2V0dGluZ19pbmZvGAkgASgLMhIuUGxheWVyU2V0dGlu",
			"Z0luZm8SGQoRZ2FtZXBsYXlfYmlydGhkYXkYASABKA0SHgoWbGFzdF9zZXRf",
			"bmlja25hbWVfdGltZRgKIAEoAxIiChp3ZWVrX2NvY29vbl9maW5pc2hlZF9j",
			"b3VudBgGIAEoDRIPCgdyZXRjb2RlGAUgASgNEg4KBmdlbmRlchgIIAEoDRIZ",
			"ChFuZXh0X3JlY292ZXJfdGltZRgMIAEoA0IeqgIbRWdnTGluay5EYW5oZW5n",
			"U2VydmVyLlByb3RvYgZwcm90bzM="
		})), new FileDescriptor[]
		{
			PlayerSettingInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GetBasicInfoScRsp), GetBasicInfoScRsp.Parser, new string[]
			{
				"IsGenderSet",
				"CurDay",
				"ExchangeTimes",
				"PlayerSettingInfo",
				"GameplayBirthday",
				"LastSetNicknameTime",
				"WeekCocoonFinishedCount",
				"Retcode",
				"Gender",
				"NextRecoverTime"
			}, null, null, null, null)
		}));
	}
}
