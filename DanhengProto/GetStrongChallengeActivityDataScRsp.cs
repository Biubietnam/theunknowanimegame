using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000813 RID: 2067
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class GetStrongChallengeActivityDataScRsp : IMessage<GetStrongChallengeActivityDataScRsp>, IMessage, IEquatable<GetStrongChallengeActivityDataScRsp>, IDeepCloneable<GetStrongChallengeActivityDataScRsp>, IBufferMessage
	{
		// Token: 0x170019EE RID: 6638
		// (get) Token: 0x06005C21 RID: 23585 RVA: 0x000F4EA7 File Offset: 0x000F30A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GetStrongChallengeActivityDataScRsp> Parser
		{
			get
			{
				return GetStrongChallengeActivityDataScRsp._parser;
			}
		}

		// Token: 0x170019EF RID: 6639
		// (get) Token: 0x06005C22 RID: 23586 RVA: 0x000F4EAE File Offset: 0x000F30AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GetStrongChallengeActivityDataScRspReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x170019F0 RID: 6640
		// (get) Token: 0x06005C23 RID: 23587 RVA: 0x000F4EC0 File Offset: 0x000F30C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStrongChallengeActivityDataScRsp.Descriptor;
			}
		}

		// Token: 0x06005C24 RID: 23588 RVA: 0x000F4EC7 File Offset: 0x000F30C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStrongChallengeActivityDataScRsp()
		{
		}

		// Token: 0x06005C25 RID: 23589 RVA: 0x000F4ED0 File Offset: 0x000F30D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStrongChallengeActivityDataScRsp(GetStrongChallengeActivityDataScRsp other) : this()
		{
			this.retcode_ = other.retcode_;
			this.iAOGNGDBNBG_ = ((other.iAOGNGDBNBG_ != null) ? other.iAOGNGDBNBG_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005C26 RID: 23590 RVA: 0x000F4F1C File Offset: 0x000F311C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetStrongChallengeActivityDataScRsp Clone()
		{
			return new GetStrongChallengeActivityDataScRsp(this);
		}

		// Token: 0x170019F1 RID: 6641
		// (get) Token: 0x06005C27 RID: 23591 RVA: 0x000F4F24 File Offset: 0x000F3124
		// (set) Token: 0x06005C28 RID: 23592 RVA: 0x000F4F2C File Offset: 0x000F312C
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

		// Token: 0x170019F2 RID: 6642
		// (get) Token: 0x06005C29 RID: 23593 RVA: 0x000F4F35 File Offset: 0x000F3135
		// (set) Token: 0x06005C2A RID: 23594 RVA: 0x000F4F3D File Offset: 0x000F313D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StrongChallengeActivityInfo IAOGNGDBNBG
		{
			get
			{
				return this.iAOGNGDBNBG_;
			}
			set
			{
				this.iAOGNGDBNBG_ = value;
			}
		}

		// Token: 0x06005C2B RID: 23595 RVA: 0x000F4F46 File Offset: 0x000F3146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStrongChallengeActivityDataScRsp);
		}

		// Token: 0x06005C2C RID: 23596 RVA: 0x000F4F54 File Offset: 0x000F3154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetStrongChallengeActivityDataScRsp other)
		{
			return other != null && (other == this || (this.Retcode == other.Retcode && object.Equals(this.IAOGNGDBNBG, other.IAOGNGDBNBG) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C2D RID: 23597 RVA: 0x000F4FA4 File Offset: 0x000F31A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Retcode != 0U)
			{
				num ^= this.Retcode.GetHashCode();
			}
			if (this.iAOGNGDBNBG_ != null)
			{
				num ^= this.IAOGNGDBNBG.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x000F4FF9 File Offset: 0x000F31F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x000F5001 File Offset: 0x000F3201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C30 RID: 23600 RVA: 0x000F500C File Offset: 0x000F320C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.iAOGNGDBNBG_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.IAOGNGDBNBG);
			}
			if (this.Retcode != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.Retcode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C31 RID: 23601 RVA: 0x000F5068 File Offset: 0x000F3268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Retcode != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Retcode);
			}
			if (this.iAOGNGDBNBG_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.IAOGNGDBNBG);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C32 RID: 23602 RVA: 0x000F50C0 File Offset: 0x000F32C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetStrongChallengeActivityDataScRsp other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Retcode != 0U)
			{
				this.Retcode = other.Retcode;
			}
			if (other.iAOGNGDBNBG_ != null)
			{
				if (this.iAOGNGDBNBG_ == null)
				{
					this.IAOGNGDBNBG = new StrongChallengeActivityInfo();
				}
				this.IAOGNGDBNBG.MergeFrom(other.IAOGNGDBNBG);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C33 RID: 23603 RVA: 0x000F5128 File Offset: 0x000F3328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C34 RID: 23604 RVA: 0x000F5134 File Offset: 0x000F3334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 10U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Retcode = input.ReadUInt32();
					}
				}
				else
				{
					if (this.iAOGNGDBNBG_ == null)
					{
						this.IAOGNGDBNBG = new StrongChallengeActivityInfo();
					}
					input.ReadMessage(this.IAOGNGDBNBG);
				}
			}
		}

		// Token: 0x0400239F RID: 9119
		private static readonly MessageParser<GetStrongChallengeActivityDataScRsp> _parser = new MessageParser<GetStrongChallengeActivityDataScRsp>(() => new GetStrongChallengeActivityDataScRsp());

		// Token: 0x040023A0 RID: 9120
		private UnknownFieldSet _unknownFields;

		// Token: 0x040023A1 RID: 9121
		public const int RetcodeFieldNumber = 3;

		// Token: 0x040023A2 RID: 9122
		private uint retcode_;

		// Token: 0x040023A3 RID: 9123
		public const int IAOGNGDBNBGFieldNumber = 1;

		// Token: 0x040023A4 RID: 9124
		private StrongChallengeActivityInfo iAOGNGDBNBG_;
	}
}
