using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x02000D9F RID: 3487
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class RelicAvatarRecommendCsReq : IMessage<RelicAvatarRecommendCsReq>, IMessage, IEquatable<RelicAvatarRecommendCsReq>, IDeepCloneable<RelicAvatarRecommendCsReq>, IBufferMessage
	{
		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x06009BCF RID: 39887 RVA: 0x0019EC0C File Offset: 0x0019CE0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RelicAvatarRecommendCsReq> Parser
		{
			get
			{
				return RelicAvatarRecommendCsReq._parser;
			}
		}

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x06009BD0 RID: 39888 RVA: 0x0019EC13 File Offset: 0x0019CE13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RelicAvatarRecommendCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x06009BD1 RID: 39889 RVA: 0x0019EC25 File Offset: 0x0019CE25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RelicAvatarRecommendCsReq.Descriptor;
			}
		}

		// Token: 0x06009BD2 RID: 39890 RVA: 0x0019EC2C File Offset: 0x0019CE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicAvatarRecommendCsReq()
		{
		}

		// Token: 0x06009BD3 RID: 39891 RVA: 0x0019EC34 File Offset: 0x0019CE34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicAvatarRecommendCsReq(RelicAvatarRecommendCsReq other) : this()
		{
			this.eOLGPJIGODN_ = other.eOLGPJIGODN_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009BD4 RID: 39892 RVA: 0x0019EC59 File Offset: 0x0019CE59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RelicAvatarRecommendCsReq Clone()
		{
			return new RelicAvatarRecommendCsReq(this);
		}

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x06009BD5 RID: 39893 RVA: 0x0019EC61 File Offset: 0x0019CE61
		// (set) Token: 0x06009BD6 RID: 39894 RVA: 0x0019EC69 File Offset: 0x0019CE69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint EOLGPJIGODN
		{
			get
			{
				return this.eOLGPJIGODN_;
			}
			set
			{
				this.eOLGPJIGODN_ = value;
			}
		}

		// Token: 0x06009BD7 RID: 39895 RVA: 0x0019EC72 File Offset: 0x0019CE72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RelicAvatarRecommendCsReq);
		}

		// Token: 0x06009BD8 RID: 39896 RVA: 0x0019EC80 File Offset: 0x0019CE80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RelicAvatarRecommendCsReq other)
		{
			return other != null && (other == this || (this.EOLGPJIGODN == other.EOLGPJIGODN && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009BD9 RID: 39897 RVA: 0x0019ECB0 File Offset: 0x0019CEB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EOLGPJIGODN != 0U)
			{
				num ^= this.EOLGPJIGODN.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009BDA RID: 39898 RVA: 0x0019ECEF File Offset: 0x0019CEEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009BDB RID: 39899 RVA: 0x0019ECF7 File Offset: 0x0019CEF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009BDC RID: 39900 RVA: 0x0019ED00 File Offset: 0x0019CF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EOLGPJIGODN != 0U)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.EOLGPJIGODN);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009BDD RID: 39901 RVA: 0x0019ED34 File Offset: 0x0019CF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EOLGPJIGODN != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.EOLGPJIGODN);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009BDE RID: 39902 RVA: 0x0019ED72 File Offset: 0x0019CF72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RelicAvatarRecommendCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EOLGPJIGODN != 0U)
			{
				this.EOLGPJIGODN = other.EOLGPJIGODN;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009BDF RID: 39903 RVA: 0x0019EDA3 File Offset: 0x0019CFA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x0019EDAC File Offset: 0x0019CFAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EOLGPJIGODN = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003C7D RID: 15485
		private static readonly MessageParser<RelicAvatarRecommendCsReq> _parser = new MessageParser<RelicAvatarRecommendCsReq>(() => new RelicAvatarRecommendCsReq());

		// Token: 0x04003C7E RID: 15486
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C7F RID: 15487
		public const int EOLGPJIGODNFieldNumber = 3;

		// Token: 0x04003C80 RID: 15488
		private uint eOLGPJIGODN_;
	}
}
