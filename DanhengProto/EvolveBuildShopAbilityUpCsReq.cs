using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004C1 RID: 1217
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildShopAbilityUpCsReq : IMessage<EvolveBuildShopAbilityUpCsReq>, IMessage, IEquatable<EvolveBuildShopAbilityUpCsReq>, IDeepCloneable<EvolveBuildShopAbilityUpCsReq>, IBufferMessage
	{
		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x00095875 File Offset: 0x00093A75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildShopAbilityUpCsReq> Parser
		{
			get
			{
				return EvolveBuildShopAbilityUpCsReq._parser;
			}
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06003665 RID: 13925 RVA: 0x0009587C File Offset: 0x00093A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityUpCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06003666 RID: 13926 RVA: 0x0009588E File Offset: 0x00093A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityUpCsReq.Descriptor;
			}
		}

		// Token: 0x06003667 RID: 13927 RVA: 0x00095895 File Offset: 0x00093A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityUpCsReq()
		{
		}

		// Token: 0x06003668 RID: 13928 RVA: 0x0009589D File Offset: 0x00093A9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityUpCsReq(EvolveBuildShopAbilityUpCsReq other) : this()
		{
			this.level_ = other.level_;
			this.iCKOBLBOKIH_ = other.iCKOBLBOKIH_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003669 RID: 13929 RVA: 0x000958CE File Offset: 0x00093ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityUpCsReq Clone()
		{
			return new EvolveBuildShopAbilityUpCsReq(this);
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x0600366A RID: 13930 RVA: 0x000958D6 File Offset: 0x00093AD6
		// (set) Token: 0x0600366B RID: 13931 RVA: 0x000958DE File Offset: 0x00093ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x0600366C RID: 13932 RVA: 0x000958E7 File Offset: 0x00093AE7
		// (set) Token: 0x0600366D RID: 13933 RVA: 0x000958EF File Offset: 0x00093AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ICKOBLBOKIH
		{
			get
			{
				return this.iCKOBLBOKIH_;
			}
			set
			{
				this.iCKOBLBOKIH_ = value;
			}
		}

		// Token: 0x0600366E RID: 13934 RVA: 0x000958F8 File Offset: 0x00093AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildShopAbilityUpCsReq);
		}

		// Token: 0x0600366F RID: 13935 RVA: 0x00095906 File Offset: 0x00093B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildShopAbilityUpCsReq other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.ICKOBLBOKIH == other.ICKOBLBOKIH && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003670 RID: 13936 RVA: 0x00095944 File Offset: 0x00093B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.ICKOBLBOKIH != 0U)
			{
				num ^= this.ICKOBLBOKIH.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003671 RID: 13937 RVA: 0x0009599C File Offset: 0x00093B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003672 RID: 13938 RVA: 0x000959A4 File Offset: 0x00093BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003673 RID: 13939 RVA: 0x000959B0 File Offset: 0x00093BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0U)
			{
				output.WriteRawTag(56);
				output.WriteUInt32(this.Level);
			}
			if (this.ICKOBLBOKIH != 0U)
			{
				output.WriteRawTag(120);
				output.WriteUInt32(this.ICKOBLBOKIH);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003674 RID: 13940 RVA: 0x00095A0C File Offset: 0x00093C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this.ICKOBLBOKIH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ICKOBLBOKIH);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003675 RID: 13941 RVA: 0x00095A64 File Offset: 0x00093C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildShopAbilityUpCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			if (other.ICKOBLBOKIH != 0U)
			{
				this.ICKOBLBOKIH = other.ICKOBLBOKIH;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003676 RID: 13942 RVA: 0x00095AB4 File Offset: 0x00093CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003677 RID: 13943 RVA: 0x00095AC0 File Offset: 0x00093CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 56U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ICKOBLBOKIH = input.ReadUInt32();
					}
				}
				else
				{
					this.Level = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040015A1 RID: 5537
		private static readonly MessageParser<EvolveBuildShopAbilityUpCsReq> _parser = new MessageParser<EvolveBuildShopAbilityUpCsReq>(() => new EvolveBuildShopAbilityUpCsReq());

		// Token: 0x040015A2 RID: 5538
		private UnknownFieldSet _unknownFields;

		// Token: 0x040015A3 RID: 5539
		public const int LevelFieldNumber = 7;

		// Token: 0x040015A4 RID: 5540
		private uint level_;

		// Token: 0x040015A5 RID: 5541
		public const int ICKOBLBOKIHFieldNumber = 15;

		// Token: 0x040015A6 RID: 5542
		private uint iCKOBLBOKIH_;
	}
}
