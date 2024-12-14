using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02001007 RID: 4103
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RogueTournResetPermanentTalentScRsp : IMessage<RogueTournResetPermanentTalentScRsp>, IMessage, IEquatable<RogueTournResetPermanentTalentScRsp>, IDeepCloneable<RogueTournResetPermanentTalentScRsp>, IBufferMessage
	{
		// Token: 0x1700336E RID: 13166
		// (get) Token: 0x0600B68D RID: 46733 RVA: 0x001E9C13 File Offset: 0x001E7E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RogueTournResetPermanentTalentScRsp> Parser
		{
			get
			{
				return RogueTournResetPermanentTalentScRsp._parser;
			}
		}

		// Token: 0x1700336F RID: 13167
		// (get) Token: 0x0600B68E RID: 46734 RVA: 0x001E9C1A File Offset: 0x001E7E1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RogueTournResetPermanentTalentScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600B68F RID: 46735 RVA: 0x001E9C2C File Offset: 0x001E7E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTournResetPermanentTalentScRsp.Descriptor;
			}
		}

		// Token: 0x0600B690 RID: 46736 RVA: 0x001E9C33 File Offset: 0x001E7E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournResetPermanentTalentScRsp()
		{
		}

		// Token: 0x0600B691 RID: 46737 RVA: 0x001E9C3C File Offset: 0x001E7E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournResetPermanentTalentScRsp(RogueTournResetPermanentTalentScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.permanentInfo_ = ((other.permanentInfo_ != null) ? other.permanentInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B692 RID: 46738 RVA: 0x001E9C88 File Offset: 0x001E7E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTournResetPermanentTalentScRsp Clone()
		{
			return new RogueTournResetPermanentTalentScRsp(this);
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600B693 RID: 46739 RVA: 0x001E9C90 File Offset: 0x001E7E90
		// (set) Token: 0x0600B694 RID: 46740 RVA: 0x001E9C98 File Offset: 0x001E7E98
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

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600B695 RID: 46741 RVA: 0x001E9CA1 File Offset: 0x001E7EA1
		// (set) Token: 0x0600B696 RID: 46742 RVA: 0x001E9CA9 File Offset: 0x001E7EA9
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

		// Token: 0x0600B697 RID: 46743 RVA: 0x001E9CB2 File Offset: 0x001E7EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTournResetPermanentTalentScRsp);
		}

		// Token: 0x0600B698 RID: 46744 RVA: 0x001E9CC0 File Offset: 0x001E7EC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTournResetPermanentTalentScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.PermanentInfo, other.PermanentInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B699 RID: 46745 RVA: 0x001E9D10 File Offset: 0x001E7F10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.permanentInfo_ != null)
			{
				num ^= this.PermanentInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B69A RID: 46746 RVA: 0x001E9D65 File Offset: 0x001E7F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B69B RID: 46747 RVA: 0x001E9D6D File Offset: 0x001E7F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B69C RID: 46748 RVA: 0x001E9D78 File Offset: 0x001E7F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Retcode);
			}
			if (this.permanentInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.PermanentInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B69D RID: 46749 RVA: 0x001E9DD4 File Offset: 0x001E7FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.permanentInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PermanentInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B69E RID: 46750 RVA: 0x001E9E2C File Offset: 0x001E802C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTournResetPermanentTalentScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.permanentInfo_ != null)
			{
				if (this.permanentInfo_ == null)
				{
					this.PermanentInfo = new RogueTournPermanentTalentInfo();
				}
				this.PermanentInfo.MergeFrom(other.PermanentInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B69F RID: 46751 RVA: 0x001E9E94 File Offset: 0x001E8094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6A0 RID: 46752 RVA: 0x001E9EA0 File Offset: 0x001E80A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 16U)
				{
					if (num != 90U)
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

		// Token: 0x040049F5 RID: 18933
		private static readonly MessageParser<RogueTournResetPermanentTalentScRsp> _parser = new MessageParser<RogueTournResetPermanentTalentScRsp>(() => new RogueTournResetPermanentTalentScRsp());

		// Token: 0x040049F6 RID: 18934
		private UnknownFieldSet _unknownFields;

		// Token: 0x040049F7 RID: 18935
		public const int RetcodeFieldNumber = 2;

		// Token: 0x040049F8 RID: 18936
		private uint retcode_;

		// Token: 0x040049F9 RID: 18937
		public const int PermanentInfoFieldNumber = 11;

		// Token: 0x040049FA RID: 18938
		private RogueTournPermanentTalentInfo permanentInfo_;
	}
}
