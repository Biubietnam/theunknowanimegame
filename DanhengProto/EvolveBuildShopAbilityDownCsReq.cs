using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace EggLink.DanhengServer.Proto
{
	// Token: 0x020004B9 RID: 1209
	[DebuggerDisplay("{ToString(),nq}")]
	public sealed class EvolveBuildShopAbilityDownCsReq : IMessage<EvolveBuildShopAbilityDownCsReq>, IMessage, IEquatable<EvolveBuildShopAbilityDownCsReq>, IDeepCloneable<EvolveBuildShopAbilityDownCsReq>, IBufferMessage
	{
		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x06003609 RID: 13833 RVA: 0x00094B75 File Offset: 0x00092D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EvolveBuildShopAbilityDownCsReq> Parser
		{
			get
			{
				return EvolveBuildShopAbilityDownCsReq._parser;
			}
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x0600360A RID: 13834 RVA: 0x00094B7C File Offset: 0x00092D7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityDownCsReqReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x00094B8E File Offset: 0x00092D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EvolveBuildShopAbilityDownCsReq.Descriptor;
			}
		}

		// Token: 0x0600360C RID: 13836 RVA: 0x00094B95 File Offset: 0x00092D95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityDownCsReq()
		{
		}

		// Token: 0x0600360D RID: 13837 RVA: 0x00094B9D File Offset: 0x00092D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityDownCsReq(EvolveBuildShopAbilityDownCsReq other) : this()
		{
			this.iCKOBLBOKIH_ = other.iCKOBLBOKIH_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600360E RID: 13838 RVA: 0x00094BCE File Offset: 0x00092DCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EvolveBuildShopAbilityDownCsReq Clone()
		{
			return new EvolveBuildShopAbilityDownCsReq(this);
		}

		// Token: 0x17000F72 RID: 3954
		// (get) Token: 0x0600360F RID: 13839 RVA: 0x00094BD6 File Offset: 0x00092DD6
		// (set) Token: 0x06003610 RID: 13840 RVA: 0x00094BDE File Offset: 0x00092DDE
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

		// Token: 0x17000F73 RID: 3955
		// (get) Token: 0x06003611 RID: 13841 RVA: 0x00094BE7 File Offset: 0x00092DE7
		// (set) Token: 0x06003612 RID: 13842 RVA: 0x00094BEF File Offset: 0x00092DEF
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

		// Token: 0x06003613 RID: 13843 RVA: 0x00094BF8 File Offset: 0x00092DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EvolveBuildShopAbilityDownCsReq);
		}

		// Token: 0x06003614 RID: 13844 RVA: 0x00094C06 File Offset: 0x00092E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EvolveBuildShopAbilityDownCsReq other)
		{
			return other != null && (other == this || (this.ICKOBLBOKIH == other.ICKOBLBOKIH && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003615 RID: 13845 RVA: 0x00094C44 File Offset: 0x00092E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ICKOBLBOKIH != 0U)
			{
				num ^= this.ICKOBLBOKIH.GetHashCode();
			}
			if (this.Level != 0U)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003616 RID: 13846 RVA: 0x00094C9C File Offset: 0x00092E9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003617 RID: 13847 RVA: 0x00094CA4 File Offset: 0x00092EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003618 RID: 13848 RVA: 0x00094CB0 File Offset: 0x00092EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ICKOBLBOKIH != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ICKOBLBOKIH);
			}
			if (this.Level != 0U)
			{
				output.WriteRawTag(112);
				output.WriteUInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003619 RID: 13849 RVA: 0x00094D0C File Offset: 0x00092F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ICKOBLBOKIH != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ICKOBLBOKIH);
			}
			if (this.Level != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600361A RID: 13850 RVA: 0x00094D64 File Offset: 0x00092F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EvolveBuildShopAbilityDownCsReq other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ICKOBLBOKIH != 0U)
			{
				this.ICKOBLBOKIH = other.ICKOBLBOKIH;
			}
			if (other.Level != 0U)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600361B RID: 13851 RVA: 0x00094DB4 File Offset: 0x00092FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600361C RID: 13852 RVA: 0x00094DC0 File Offset: 0x00092FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if (num != 72U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadUInt32();
					}
				}
				else
				{
					this.ICKOBLBOKIH = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001584 RID: 5508
		private static readonly MessageParser<EvolveBuildShopAbilityDownCsReq> _parser = new MessageParser<EvolveBuildShopAbilityDownCsReq>(() => new EvolveBuildShopAbilityDownCsReq());

		// Token: 0x04001585 RID: 5509
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001586 RID: 5510
		public const int ICKOBLBOKIHFieldNumber = 9;

		// Token: 0x04001587 RID: 5511
		private uint iCKOBLBOKIH_;

		// Token: 0x04001588 RID: 5512
		public const int LevelFieldNumber = 14;

		// Token: 0x04001589 RID: 5513
		private uint level_;
	}
}
