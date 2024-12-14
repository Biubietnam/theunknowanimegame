using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000F9F RID: 3999
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournEnablePermanentTalentScRsp : IMessage<RogueTournEnablePermanentTalentScRsp>, IMessage, IEquatable<RogueTournEnablePermanentTalentScRsp>, IDeepCloneable<RogueTournEnablePermanentTalentScRsp>, IBufferMessage
	{
		// Token: 0x17003242 RID: 12866
		// (get) Token: 0x0600B22E RID: 45614 RVA: 0x001DEDCF File Offset: 0x001DCFCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournEnablePermanentTalentScRsp> Parser
		{
			get
			{
				return RogueTournEnablePermanentTalentScRsp._parser;
			}
		}

		// Token: 0x17003243 RID: 12867
		// (get) Token: 0x0600B22F RID: 45615 RVA: 0x001DEDD6 File Offset: 0x001DCFD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournEnablePermanentTalentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003244 RID: 12868
		// (get) Token: 0x0600B230 RID: 45616 RVA: 0x001DEDE8 File Offset: 0x001DCFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournEnablePermanentTalentScRsp.Descriptor;
			}
		}

		// Token: 0x0600B231 RID: 45617 RVA: 0x001DEDEF File Offset: 0x001DCFEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnablePermanentTalentScRsp()
		{
		}

		// Token: 0x0600B232 RID: 45618 RVA: 0x001DEDF8 File Offset: 0x001DCFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnablePermanentTalentScRsp(RogueTournEnablePermanentTalentScRsp other) : this()
		{
			this.permanentInfo_ = ((other.permanentInfo_ != null) ? other.permanentInfo_.Clone() : null);
			this.retcode_ = other.retcode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B233 RID: 45619 RVA: 0x001DEE44 File Offset: 0x001DD044
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournEnablePermanentTalentScRsp Clone()
		{
			return new RogueTournEnablePermanentTalentScRsp(this);
		}

		// Token: 0x17003245 RID: 12869
		// (get) Token: 0x0600B234 RID: 45620 RVA: 0x001DEE4C File Offset: 0x001DD04C
		// (set) Token: 0x0600B235 RID: 45621 RVA: 0x001DEE54 File Offset: 0x001DD054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournPermanentTalentInfo PermanentInfo
		{
			get
			{
				return this.permanentInfo_;
			}
			set
			{
				this.permanentInfo_ = value;
			}
		}

		// Token: 0x17003246 RID: 12870
		// (get) Token: 0x0600B236 RID: 45622 RVA: 0x001DEE5D File Offset: 0x001DD05D
		// (set) Token: 0x0600B237 RID: 45623 RVA: 0x001DEE65 File Offset: 0x001DD065
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

		// Token: 0x0600B238 RID: 45624 RVA: 0x001DEE6E File Offset: 0x001DD06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournEnablePermanentTalentScRsp);
		}

		// Token: 0x0600B239 RID: 45625 RVA: 0x001DEE7C File Offset: 0x001DD07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournEnablePermanentTalentScRsp other)
		{
			return other != null && (other == this || (object.Equals(this.PermanentInfo, other.PermanentInfo) && this.Retcode == other.Retcode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B23A RID: 45626 RVA: 0x001DEECC File Offset: 0x001DD0CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.permanentInfo_ != null)
			{
				num ^= this.PermanentInfo.GetHashCode();
			}
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B23B RID: 45627 RVA: 0x001DEF21 File Offset: 0x001DD121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B23C RID: 45628 RVA: 0x001DEF29 File Offset: 0x001DD129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B23D RID: 45629 RVA: 0x001DEF34 File Offset: 0x001DD134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(this.Retcode);
			}
			if (this.permanentInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PermanentInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B23E RID: 45630 RVA: 0x001DEF90 File Offset: 0x001DD190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.permanentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PermanentInfo);
			}
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B23F RID: 45631 RVA: 0x001DEFE8 File Offset: 0x001DD1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournEnablePermanentTalentScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.permanentInfo_ != null)
			{
				if (this.permanentInfo_ == null)
				{
					this.PermanentInfo = new RogueTournPermanentTalentInfo();
				}
				this.PermanentInfo.MergeFrom(other.PermanentInfo);
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B240 RID: 45632 RVA: 0x001DF050 File Offset: 0x001DD250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B241 RID: 45633 RVA: 0x001DF05C File Offset: 0x001DD25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 40U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.permanentInfo_ == null)
						{
							this.PermanentInfo = new RogueTournPermanentTalentInfo();
						}
						input.ReadMessage(this.PermanentInfo);
					}
				}
				else
				{
					this.Retcode = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04004871 RID: 18545
		private static readonly MessageParser<RogueTournEnablePermanentTalentScRsp> _parser = new MessageParser<RogueTournEnablePermanentTalentScRsp>(() => new RogueTournEnablePermanentTalentScRsp());

		// Token: 0x04004872 RID: 18546
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004873 RID: 18547
		public const int PermanentInfoFieldNumber = 15;

		// Token: 0x04004874 RID: 18548
		private RogueTournPermanentTalentInfo permanentInfo_;

		// Token: 0x04004875 RID: 18549
		public const int RetcodeFieldNumber = 5;

		// Token: 0x04004876 RID: 18550
		private uint retcode_;
	}
}
