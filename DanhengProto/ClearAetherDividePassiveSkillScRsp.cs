using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020002D3 RID: 723
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class ClearAetherDividePassiveSkillScRsp : IMessage<ClearAetherDividePassiveSkillScRsp>, IMessage, IEquatable<ClearAetherDividePassiveSkillScRsp>, IDeepCloneable<ClearAetherDividePassiveSkillScRsp>, IBufferMessage
	{
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x0005B917 File Offset: 0x00059B17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ClearAetherDividePassiveSkillScRsp> Parser
		{
			get
			{
				return ClearAetherDividePassiveSkillScRsp._parser;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x0005B91E File Offset: 0x00059B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClearAetherDividePassiveSkillScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x0005B930 File Offset: 0x00059B30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClearAetherDividePassiveSkillScRsp.Descriptor;
			}
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x0005B937 File Offset: 0x00059B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClearAetherDividePassiveSkillScRsp()
		{
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x0005B940 File Offset: 0x00059B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClearAetherDividePassiveSkillScRsp(ClearAetherDividePassiveSkillScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.aetherSkillInfo_ = ((other.aetherSkillInfo_ != null) ? other.aetherSkillInfo_.Clone() : null);
			this.aetherInfo_ = ((other.aetherInfo_ != null) ? other.aetherInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x0005B9A8 File Offset: 0x00059BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClearAetherDividePassiveSkillScRsp Clone()
		{
			return new ClearAetherDividePassiveSkillScRsp(this);
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x0005B9B0 File Offset: 0x00059BB0
		// (set) Token: 0x06002036 RID: 8246 RVA: 0x0005B9B8 File Offset: 0x00059BB8
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

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x0005B9C1 File Offset: 0x00059BC1
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x0005B9C9 File Offset: 0x00059BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherSkillInfo AetherSkillInfo
		{
			get
			{
				return this.aetherSkillInfo_;
			}
			set
			{
				this.aetherSkillInfo_ = value;
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x06002039 RID: 8249 RVA: 0x0005B9D2 File Offset: 0x00059BD2
		// (set) Token: 0x0600203A RID: 8250 RVA: 0x0005B9DA File Offset: 0x00059BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AetherDivideSpiritInfo AetherInfo
		{
			get
			{
				return this.aetherInfo_;
			}
			set
			{
				this.aetherInfo_ = value;
			}
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x0005B9E3 File Offset: 0x00059BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClearAetherDividePassiveSkillScRsp);
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0005B9F4 File Offset: 0x00059BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClearAetherDividePassiveSkillScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.AetherSkillInfo, other.AetherSkillInfo) && object.Equals(this.AetherInfo, other.AetherInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0005BA58 File Offset: 0x00059C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.aetherSkillInfo_ != null)
			{
				num ^= this.AetherSkillInfo.GetHashCode();
			}
			if (this.aetherInfo_ != null)
			{
				num ^= this.AetherInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0005BAC3 File Offset: 0x00059CC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0005BACB File Offset: 0x00059CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0005BAD4 File Offset: 0x00059CD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this.aetherInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.AetherInfo);
			}
			if (this.aetherSkillInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.AetherSkillInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x0005BB4C File Offset: 0x00059D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.aetherSkillInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AetherSkillInfo);
			}
			if (this.aetherInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AetherInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0005BBBC File Offset: 0x00059DBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClearAetherDividePassiveSkillScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.aetherSkillInfo_ != null)
			{
				if (this.aetherSkillInfo_ == null)
				{
					this.AetherSkillInfo = new AetherSkillInfo();
				}
				this.AetherSkillInfo.MergeFrom(other.AetherSkillInfo);
			}
			if (other.aetherInfo_ != null)
			{
				if (this.aetherInfo_ == null)
				{
					this.AetherInfo = new AetherDivideSpiritInfo();
				}
				this.AetherInfo.MergeFrom(other.AetherInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x0005BC50 File Offset: 0x00059E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x0005BC5C File Offset: 0x00059E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					if (num != 58U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.aetherSkillInfo_ == null)
							{
								this.AetherSkillInfo = new AetherSkillInfo();
							}
							input.ReadMessage(this.AetherSkillInfo);
						}
					}
					else
					{
						if (this.aetherInfo_ == null)
						{
							this.AetherInfo = new AetherDivideSpiritInfo();
						}
						input.ReadMessage(this.AetherInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04000D50 RID: 3408
		private static readonly MessageParser<ClearAetherDividePassiveSkillScRsp> _parser = new MessageParser<ClearAetherDividePassiveSkillScRsp>(() => new ClearAetherDividePassiveSkillScRsp());

		// Token: 0x04000D51 RID: 3409
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000D52 RID: 3410
		public const int RetcodeFieldNumber = 3;

		// Token: 0x04000D53 RID: 3411
		private uint retcode_;

		// Token: 0x04000D54 RID: 3412
		public const int AetherSkillInfoFieldNumber = 15;

		// Token: 0x04000D55 RID: 3413
		private AetherSkillInfo aetherSkillInfo_;

		// Token: 0x04000D56 RID: 3414
		public const int AetherInfoFieldNumber = 7;

		// Token: 0x04000D57 RID: 3415
		private AetherDivideSpiritInfo aetherInfo_;
	}
}
