using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020006E7 RID: 1767
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetHeartDialInfoScRsp : IMessage<GetHeartDialInfoScRsp>, IMessage, IEquatable<GetHeartDialInfoScRsp>, IDeepCloneable<GetHeartDialInfoScRsp>, IBufferMessage
	{
		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06004F07 RID: 20231 RVA: 0x000D5938 File Offset: 0x000D3B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetHeartDialInfoScRsp> Parser
		{
			get
			{
				return GetHeartDialInfoScRsp._parser;
			}
		}

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06004F08 RID: 20232 RVA: 0x000D593F File Offset: 0x000D3B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetHeartDialInfoScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06004F09 RID: 20233 RVA: 0x000D5951 File Offset: 0x000D3B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetHeartDialInfoScRsp.Descriptor;
			}
		}

		// Token: 0x06004F0A RID: 20234 RVA: 0x000D5958 File Offset: 0x000D3B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetHeartDialInfoScRsp()
		{
		}

		// Token: 0x06004F0B RID: 20235 RVA: 0x000D5984 File Offset: 0x000D3B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetHeartDialInfoScRsp(GetHeartDialInfoScRsp other) : this()
		{
			this.scriptInfoList_ = other.scriptInfoList_.Clone();
			this.retcode_ = other.retcode_;
			this.unlockStatus_ = other.unlockStatus_;
			this.dialogueInfoList_ = other.dialogueInfoList_.Clone();
			this.nDKJOPLLDPH_ = other.nDKJOPLLDPH_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004F0C RID: 20236 RVA: 0x000D59F3 File Offset: 0x000D3BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetHeartDialInfoScRsp Clone()
		{
			return new GetHeartDialInfoScRsp(this);
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06004F0D RID: 20237 RVA: 0x000D59FB File Offset: 0x000D3BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HeartDialScriptInfo> ScriptInfoList
		{
			get
			{
				return this.scriptInfoList_;
			}
		}

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x06004F0E RID: 20238 RVA: 0x000D5A03 File Offset: 0x000D3C03
		// (set) Token: 0x06004F0F RID: 20239 RVA: 0x000D5A0B File Offset: 0x000D3C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Retcode
		{
			get
			{
				return this.retcode_;
			}
			set
			{
				this.retcode_ = value;
			}
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06004F10 RID: 20240 RVA: 0x000D5A14 File Offset: 0x000D3C14
		// (set) Token: 0x06004F11 RID: 20241 RVA: 0x000D5A1C File Offset: 0x000D3C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HeartDialUnlockStatus UnlockStatus
		{
			get
			{
				return this.unlockStatus_;
			}
			set
			{
				this.unlockStatus_ = value;
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06004F12 RID: 20242 RVA: 0x000D5A25 File Offset: 0x000D3C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HeartDialDialogueInfo> DialogueInfoList
		{
			get
			{
				return this.dialogueInfoList_;
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06004F13 RID: 20243 RVA: 0x000D5A2D File Offset: 0x000D3C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<KGHFJPEGBNL> NDKJOPLLDPH
		{
			get
			{
				return this.nDKJOPLLDPH_;
			}
		}

		// Token: 0x06004F14 RID: 20244 RVA: 0x000D5A35 File Offset: 0x000D3C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetHeartDialInfoScRsp);
		}

		// Token: 0x06004F15 RID: 20245 RVA: 0x000D5A44 File Offset: 0x000D3C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetHeartDialInfoScRsp other)
		{
			return other != null && (other == this || (this.scriptInfoList_.Equals(other.scriptInfoList_) && this.Retcode == other.Retcode && this.UnlockStatus == other.UnlockStatus && this.dialogueInfoList_.Equals(other.dialogueInfoList_) && this.nDKJOPLLDPH_.Equals(other.nDKJOPLLDPH_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004F16 RID: 20246 RVA: 0x000D5ACC File Offset: 0x000D3CCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.scriptInfoList_.GetHashCode();
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.UnlockStatus != HeartDialUnlockStatus.Lock)
			{
				num ^= this.UnlockStatus.GetHashCode();
			}
			num ^= this.dialogueInfoList_.GetHashCode();
			num ^= this.nDKJOPLLDPH_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004F17 RID: 20247 RVA: 0x000D5B54 File Offset: 0x000D3D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004F18 RID: 20248 RVA: 0x000D5B5C File Offset: 0x000D3D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004F19 RID: 20249 RVA: 0x000D5B68 File Offset: 0x000D3D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Retcode);
			}
			this.nDKJOPLLDPH_.WriteTo(ref output, GetHeartDialInfoScRsp._repeated_nDKJOPLLDPH_codec);
			this.scriptInfoList_.WriteTo(ref output, GetHeartDialInfoScRsp._repeated_scriptInfoList_codec);
			if (this.UnlockStatus != HeartDialUnlockStatus.Lock)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.UnlockStatus);
			}
			this.dialogueInfoList_.WriteTo(ref output, GetHeartDialInfoScRsp._repeated_dialogueInfoList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004F1A RID: 20250 RVA: 0x000D5BF4 File Offset: 0x000D3DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.scriptInfoList_.CalculateSize(GetHeartDialInfoScRsp._repeated_scriptInfoList_codec);
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.UnlockStatus != HeartDialUnlockStatus.Lock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.UnlockStatus);
			}
			num += this.dialogueInfoList_.CalculateSize(GetHeartDialInfoScRsp._repeated_dialogueInfoList_codec);
			num += this.nDKJOPLLDPH_.CalculateSize(GetHeartDialInfoScRsp._repeated_nDKJOPLLDPH_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004F1B RID: 20251 RVA: 0x000D5C84 File Offset: 0x000D3E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetHeartDialInfoScRsp other)
		{
			if (other == null)
			{
				return;
			}
			this.scriptInfoList_.Add(other.scriptInfoList_);
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.UnlockStatus != HeartDialUnlockStatus.Lock)
			{
				this.UnlockStatus = other.UnlockStatus;
			}
			this.dialogueInfoList_.Add(other.dialogueInfoList_);
			this.nDKJOPLLDPH_.Add(other.nDKJOPLLDPH_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004F1C RID: 20252 RVA: 0x000D5D07 File Offset: 0x000D3F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004F1D RID: 20253 RVA: 0x000D5D10 File Offset: 0x000D3F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num <= 26U)
				{
					if (num == 8U)
					{
						this.Retcode = input.ReadUInt32();
						continue;
					}
					if (num == 26U)
					{
						this.nDKJOPLLDPH_.AddEntriesFrom(ref input, GetHeartDialInfoScRsp._repeated_nDKJOPLLDPH_codec);
						continue;
					}
				}
				else
				{
					if (num == 50U)
					{
						this.scriptInfoList_.AddEntriesFrom(ref input, GetHeartDialInfoScRsp._repeated_scriptInfoList_codec);
						continue;
					}
					if (num == 80U)
					{
						this.UnlockStatus = (HeartDialUnlockStatus)input.ReadEnum();
						continue;
					}
					if (num == 98U)
					{
						this.dialogueInfoList_.AddEntriesFrom(ref input, GetHeartDialInfoScRsp._repeated_dialogueInfoList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04001F29 RID: 7977
		private static readonly MessageParser<GetHeartDialInfoScRsp> _parser = new MessageParser<GetHeartDialInfoScRsp>(() => new GetHeartDialInfoScRsp());

		// Token: 0x04001F2A RID: 7978
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F2B RID: 7979
		public const int ScriptInfoListFieldNumber = 6;

		// Token: 0x04001F2C RID: 7980
		private static readonly FieldCodec<HeartDialScriptInfo> _repeated_scriptInfoList_codec = FieldCodec.ForMessage<HeartDialScriptInfo>(50U, HeartDialScriptInfo.Parser);

		// Token: 0x04001F2D RID: 7981
		private readonly RepeatedField<HeartDialScriptInfo> scriptInfoList_ = new RepeatedField<HeartDialScriptInfo>();

		// Token: 0x04001F2E RID: 7982
		public const int RetcodeFieldNumber = 1;

		// Token: 0x04001F2F RID: 7983
		private uint retcode_;

		// Token: 0x04001F30 RID: 7984
		public const int UnlockStatusFieldNumber = 10;

		// Token: 0x04001F31 RID: 7985
		private HeartDialUnlockStatus unlockStatus_;

		// Token: 0x04001F32 RID: 7986
		public const int DialogueInfoListFieldNumber = 12;

		// Token: 0x04001F33 RID: 7987
		private static readonly FieldCodec<HeartDialDialogueInfo> _repeated_dialogueInfoList_codec = FieldCodec.ForMessage<HeartDialDialogueInfo>(98U, HeartDialDialogueInfo.Parser);

		// Token: 0x04001F34 RID: 7988
		private readonly RepeatedField<HeartDialDialogueInfo> dialogueInfoList_ = new RepeatedField<HeartDialDialogueInfo>();

		// Token: 0x04001F35 RID: 7989
		public const int NDKJOPLLDPHFieldNumber = 3;

		// Token: 0x04001F36 RID: 7990
		private static readonly FieldCodec<KGHFJPEGBNL> _repeated_nDKJOPLLDPH_codec = FieldCodec.ForMessage<KGHFJPEGBNL>(26U, KGHFJPEGBNL.Parser);

		// Token: 0x04001F37 RID: 7991
		private readonly RepeatedField<KGHFJPEGBNL> nDKJOPLLDPH_ = new RepeatedField<KGHFJPEGBNL>();
	}
}
