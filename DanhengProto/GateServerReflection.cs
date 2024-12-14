using System;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020005E6 RID: 1510
	public static class GateServerReflection
	{
		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06004366 RID: 17254 RVA: 0x000B76E5 File Offset: 0x000B58E5
		public static FileDescriptor Descriptor
		{
			get
			{
				return GateServerReflection.descriptor;
			}
		}

		// Token: 0x04001AC1 RID: 6849
		private static FileDescriptor descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(new string[]
		{
			"ChBHYXRlU2VydmVyLnByb3RvIu0LCgpHYXRlU2VydmVyEhQKC0xLREZDSE5F",
			"RkJCGOYEIAEoCRIUCgtMSEdLREdESklIQxiQBiABKAkSHQoVZW5hYmxlX3Zl",
			"cnNpb25fdXBkYXRlGAogASgIEhgKD2VuYWJsZV9jZG5faXB2NhjbCSABKA0S",
			"GQoQZW5hYmxlX3dhdGVybWFyaxjGAiABKAgSCwoDbXNnGAggASgJEhEKCGlm",
			"aXhfdXJsGPICIAEoCRITCgptdHBfc3dpdGNoGOIPIAEoCBITCgtJQUxPRUtH",
			"T0pPQxgGIAEoCBIUCgtCSk9DQU5JQkJLSRi0CiABKAkSJgodZW5hYmxlX2Fu",
			"ZHJvaWRfbWlkZGxlX3BhY2thZ2UYpgwgASgIEhUKDGlmaXhfdmVyc2lvbhi5",
			"BCABKAkSFAoLSUlKTEZJTEZNREYYigEgASgJEhQKC0ZJT0hFS0RKTkNHGMUG",
			"IAEoCBIYCg9sb2dpbl93aGl0ZV9tc2cYkwUgASgJEhQKC0FQSkVDSk1HQUtD",
			"GMEEIAEoCBIhChhkZXNpZ25fZGF0YV9yZWxvZ2luX2Rlc2MYiwggASgJEhgK",
			"D21ka19yZXNfdmVyc2lvbhjPCiABKAkSGgoRY2xpZW50X3NlY3JldF9rZXkY",
			"xAMgASgJEhUKDGlwdjZfYWRkcmVzcxigDyABKAkSFAoLUE1BQk5ORURDQ0cY",
			"9AcgASgJEhQKC0tMSUFHSEdPRk1MGN0JIAEoCRIcChNldmVudF90cmFja2lu",
			"Z19vcGVuGMoOIAEoCBIUCgtPRE9DRkNKTUJDTBjRAiABKAkSFAoLTlBJR1BC",
			"RUtFS08Y0AMgASgJEgoKAmlwGAUgASgJEhMKC3JlZ2lvbl9uYW1lGAwgASgJ",
			"EhQKC0tEQkFHQUxIRURDGOIIIAEoCRIZChFjbG9zZV9yZWRlZW1fY29kZRg+",
			"IAEoCBIZChFyZWdpb25fc3RvcF9zdGFydBgEIAEoAxIQCgd1c2VfdGNwGKEF",
			"IAEoCBIUCgtGREdGRkNNQUxQSRjuCCABKAkSFwoPZXhfcmVzb3VyY2VfdXJs",
			"GAEgASgJEhQKC0ZIQUxOQ0lITUdBGNAEIAEoCRIqCiFwbGF5ZXJfcmV0dXJu",
			"X3F1ZXN0aW9ubmFpcmVfYV91cmwY5Q4gASgJEg8KB3JldGNvZGUYAiABKA0S",
			"EwoLSVBLTEFNTUtOTkcYdSABKAkSJAobcGxheWVyX3JldHVybl9pbnZpdGVf",
			"aDVfdXJsGJQMIAEoCRIYChBhc2JfcmVsb2dpbl90eXBlGA0gASgNEhQKC0NO",
			"QUtMR01ETFBFGKYDIAEoCBIPCgdsdWFfdXJsGAMgASgJEhkKEHByZV9kb3du",
			"bG9hZF91cmwY7QIgASgJEhgKD2ZvcmJpZF9yZWNoYXJnZRinDSABKAgSIQoY",
			"ZW5hYmxlX3VwbG9hZF9iYXR0bGVfbG9nGNQCIAEoCBIjChpvbmxpbmVfcmVw",
			"bGF5X2Rvd25sb2FkX3VybBjCByABKAkSGwoSbmV0d29ya19kaWFnbm9zdGlj",
			"GPYNIAEoCBIYChBhc3NldF9idW5kbGVfdXJsGAkgASgJEhQKC0JCRk9BSkdM",
			"TEJDGOMCIAEoCRIhChhvbmxpbmVfcmVwbGF5X3VwbG9hZF91cmwYmwogASgJ",
			"EhQKC0dCT05MREVNQkVOGLQMIAMoCRIqCiFwbGF5ZXJfcmV0dXJuX3F1ZXN0",
			"aW9ubmFpcmVfYl91cmwYtgogASgJEhgKEGFzYl9yZWxvZ2luX2Rlc2MYDiAB",
			"KAkSEQoIaW9zX2V4YW0YpwwgASgIEhQKC0tLSEZLTUlLRklCGOoCIAEoCRIU",
			"CgtNREtESkxOSEdLThjYDCABKAkSFAoLRUxKSU1HSkxIQkMY8w0gASgJEhcK",
			"D3JlZ2lvbl9zdG9wX2VuZBgPIAEoAxIaChJzZXJ2ZXJfZGVzY3JpcHRpb24Y",
			"FCABKAkSIAoYZGVzaWduX2RhdGFfcmVsb2dpbl90eXBlGAcgASgNEgwKBHBv",
			"cnQYCyABKA1CHqoCG0VnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90b2IGcHJv",
			"dG8z"
		})), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[]
		{
			new GeneratedClrTypeInfo(typeof(GateServer), GateServer.Parser, new string[]
			{
				"LKDFCHNEFBB",
				"LHGKDGDJIHC",
				"EnableVersionUpdate",
				"EnableCdnIpv6",
				"EnableWatermark",
				"Msg",
				"IfixUrl",
				"MtpSwitch",
				"IALOEKGOJOC",
				"BJOCANIBBKI",
				"EnableAndroidMiddlePackage",
				"IfixVersion",
				"IIJLFILFMDF",
				"FIOHEKDJNCG",
				"LoginWhiteMsg",
				"APJECJMGAKC",
				"DesignDataReloginDesc",
				"MdkResVersion",
				"ClientSecretKey",
				"Ipv6Address",
				"PMABNNEDCCG",
				"KLIAGHGOFML",
				"EventTrackingOpen",
				"ODOCFCJMBCL",
				"NPIGPBEKEKO",
				"Ip",
				"RegionName",
				"KDBAGALHEDC",
				"CloseRedeemCode",
				"RegionStopStart",
				"UseTcp",
				"FDGFFCMALPI",
				"ExResourceUrl",
				"FHALNCIHMGA",
				"PlayerReturnQuestionnaireAUrl",
				"Retcode",
				"IPKLAMMKNNG",
				"PlayerReturnInviteH5Url",
				"AsbReloginType",
				"CNAKLGMDLPE",
				"LuaUrl",
				"PreDownloadUrl",
				"ForbidRecharge",
				"EnableUploadBattleLog",
				"OnlineReplayDownloadUrl",
				"NetworkDiagnostic",
				"AssetBundleUrl",
				"BBFOAJGLLBC",
				"OnlineReplayUploadUrl",
				"GBONLDEMBEN",
				"PlayerReturnQuestionnaireBUrl",
				"AsbReloginDesc",
				"IosExam",
				"KKHFKMIKFIB",
				"MDKDJLNHGKN",
				"ELJIMGJLHBC",
				"RegionStopEnd",
				"ServerDescription",
				"DesignDataReloginType",
				"Port"
			}, null, null, null, null)
		}));
	}
}
